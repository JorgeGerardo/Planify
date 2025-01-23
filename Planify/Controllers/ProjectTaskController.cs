﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Planify.Models;
using Planify.Repositories;
using Planify.Repositories.UoW;
using Planify.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Planify.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public partial class ProjectTaskController : GenericController<ProjectTask, ProjectTaskRepository, ProjectTaskCreateDTO, ProjectTaskUpdateDTO>
    {
        private readonly IProjectManagement_UoW UoW;
        public ProjectTaskController(IProjectManagement_UoW uow) :
            base(uow.projectTasks)
        { UoW = uow; }
    }

    //Mpas
    public partial class ProjectTaskController
    {
        //Create:
        protected override ProjectTask MapToEntity(ProjectTaskCreateDTO dto) =>
            MapToEntityAsync(dto).GetAwaiter().GetResult();

        protected override async Task<ProjectTask> MapToEntityAsync(ProjectTaskCreateDTO dto)
        {
            bool existeProject = await UoW.projects.ExistAsync(p => p.Id.Equals(dto.ProjectId));

            if (!existeProject)
                throw new Exception("El proyecto especificado no existe.");

            return new ProjectTask
            {
                Name = dto.Name,
                ProjectId = dto.ProjectId,
                Description = dto.Description,
                Priority = dto.Priority,
                StartDate = dto.StartDate,
                EstimatedEndDate = dto.EstimatedEndDate,
            };
        }


        //Update
        protected override ProjectTask MapToUpdateEntity(ProjectTask currentState, ProjectTaskUpdateDTO dto) =>
            MapToUpdateEntityAsync(currentState, dto).GetAwaiter().GetResult();

        protected override async Task<ProjectTask> MapToUpdateEntityAsync(ProjectTask currentState, ProjectTaskUpdateDTO dto)
        {
            bool exist = await UoW.projects.ExistAsync(p => p.Id.Equals(dto.ProjectId));
            if (!exist)
                throw new Exception("El proyecto especificado no existe.");

            currentState.Name = dto.Name ?? currentState.Name;
            currentState.Description = dto.Description ?? currentState.Description;

            currentState.StartDate = dto.StartDate ?? currentState.StartDate;
            currentState.EstimatedEndDate = dto.EstimatedEndDate ?? currentState.EstimatedEndDate;
            currentState.EstimatedEndDate = dto.EstimatedEndDate ?? currentState.EstimatedEndDate;

            currentState.CompleteDate = dto.CompleteDate ?? currentState.CompleteDate;
            currentState.Priority = dto.Priority ?? currentState.Priority;
            currentState.Status = dto.Status ?? currentState.Status;


            if (dto.IsCompleted is not null && dto.IsCompleted is true)
                currentState.Status = Models.TaskStatus.Completed;

            if (dto.Status == Models.TaskStatus.Completed)
                currentState.IsCompleted = true;

            
            currentState.IsCompleted = dto.IsCompleted ?? currentState.IsCompleted;

            return currentState;
        }
    }


    //Set Policies
    public partial class ProjectTaskController
    {
        [Authorize(Policy = PolicyNames.MinimumManagerOrViewer)]
        public override Task<IEnumerable<ProjectTask>> Get(int page = 0, int? pageSize = null) =>
            base.Get(page, pageSize);

        [Authorize(Policy = PolicyNames.MinimumManagerOrViewer)]
        public override Task<ActionResult<ProjectTask>> GetById(int id) =>
            base.GetById(id);

        [Authorize(Policy = PolicyNames.MinimumManager)]
        public override Task<IActionResult> Update(int id, ProjectTaskUpdateDTO createDto) =>
            base.Update(id, createDto);

        [Authorize(Policy = PolicyNames.MinimumManager)]
        public override Task<IActionResult> Add([FromBody] ProjectTaskCreateDTO createDto) =>
            base.Add(createDto);


        [Authorize(Policy = PolicyNames.MinimumAdmin)]
        public override Task<IEnumerable<ProjectTask>> GetWithoutFiltters(int page = 0, int? pageSize = null) =>
            base.GetWithoutFiltters(page, pageSize);

        [Authorize(Policy = PolicyNames.MinimumManager)]
        public override Task<IActionResult> Delete(int id) =>
            base.Delete(id);
    }


    //Assign-Unassign employees
    public partial class ProjectTaskController
    {
        [HttpPatch("assign-employees/{id}")]
        [Authorize(Policy = PolicyNames.MinimumManager)]
        public async Task<ActionResult> AssignEmployees(int id, List<int> EmployeesIds)
        {
            var task = await UoW.projectTasks.GetById(id);
            if (task == null) return NotFound(new ProblemDetails { Detail = "La tarea no se encontró." });

            foreach (var employeeId in EmployeesIds)
            {
                Employee? e = await UoW.Employees.GetById(employeeId);
                if (e is null)
                    return NotFound(new ProblemDetails
                    { Detail = $"El usuario con el id {employeeId} no existe. " +
                        $"Ningún cambio fue realizado."
                    });
                task.Employees.Add(e);
            }

            await UoW.SaveAsync();
            return NoContent();
        }

        [HttpPatch("unassign-employees/{id}")]
        [Authorize(Policy = PolicyNames.MinimumManager)]
        public async Task<ActionResult> UnassignEmployees(int id, List<int> EmployeesIds)
        {
            var task = await UoW.projectTasks.GetById(id);
            if (task is null) return NotFound(new ProblemDetails { Detail = "La tarea no se encontró." });

            foreach (var employeeId in EmployeesIds)
            {
                Employee? e = await UoW.Employees.GetById(employeeId);
                if (e == null)
                    return NotFound(new ProblemDetails
                    { Detail = $"El usuario con el id {employeeId} no existe. " +
                        $"Ningún cambio fue realizado."
                    });
                task.Employees.Remove(e);
            }

            await UoW.SaveAsync();
            return NoContent();
        }

    }


    //User tasks
    public partial class ProjectTaskController
    {
        [HttpGet("my-incomplete-tasks")]
        [Authorize(Policy = PolicyNames.MinimumDeveloper)]
        public async Task<ActionResult<List<ProjectTask>>> GetMyIncompleteTasks()
        {
            if (!(Int32.TryParse(HttpContext.User?.Identity?.Name, out int UserId)))
                return StatusCode(500);

            return await UoW.projectTasks.GetAll()
                .Where(t => !t.IsCompleted && t.Employees.Any(e => e.UserId == UserId))
                .ToListAsync();
        }


        [HttpGet("my-complete-tasks")]
        [Authorize(Policy = PolicyNames.MinimumDeveloper)]
        public async Task<ActionResult<List<ProjectTask>>> GetMyCompletedTasks()
        {
            if (!(Int32.TryParse(HttpContext.User?.Identity?.Name, out int UserId)))
                return StatusCode(500);

            return await UoW.projectTasks.GetAll()
                .Where(t => t.IsCompleted && t.Employees.Any(e => e.UserId == UserId))
                .ToListAsync();
        }



        [HttpGet("user-incomplete-tasks/{userId}")]
        [Authorize(Policy = PolicyNames.MinimumManagerOrViewer)]
        public async Task<ActionResult<List<ProjectTask>>> GetUserIncompleteTasks(int userId) =>
            await UoW.projectTasks.GetAll()
                .Where(t => !t.IsCompleted && t.Employees.Any(e => e.UserId == userId))
                .ToListAsync();


        [HttpGet("user-completed-tasks/{userId}")]
        [Authorize(Policy = PolicyNames.MinimumManagerOrViewer)]
        public async Task<ActionResult<List<ProjectTask>>> GetUserCompletedTasks(int userId) =>
            await UoW.projectTasks.GetAll()
                .Where(t => t.IsCompleted && t.Employees.Any(e => e.UserId == userId))
                .ToListAsync();






    }


}
