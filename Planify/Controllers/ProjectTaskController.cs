﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Planify.Models;
using Planify.Repositories;
using Planify.Repositories.UoW;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Planify.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public partial class ProjectTaskController : GenericController<ProjectTask, ProjectTaskRepository, ProjectTaskCreateDTO, ProjectTaskUpdateDTO>
    {
        private readonly IProjectManagement_UoW UoW;
        public ProjectTaskController(IProjectManagement_UoW uow) :
            base(uow.projectTasks)
        { UoW = uow; }
    }

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

            currentState.Name = dto.Name;
            currentState.Description = dto.Description ?? currentState.Description;

            currentState.StartDate = dto.StartDate ?? currentState.StartDate;
            currentState.EstimatedEndDate = dto.EstimatedEndDate ?? currentState.EstimatedEndDate;
            currentState.EstimatedEndDate = dto.EstimatedEndDate ?? currentState.EstimatedEndDate;

            currentState.CompleteDate = dto.CompleteDate ?? currentState.CompleteDate;
            currentState.Priority = dto.Priority ?? currentState.Priority;
            currentState.Status = dto.Status;
            currentState.IsCompleted = dto.IsCompleted;

            return currentState;
        }
    }

    //Assign-Unassign employees
    public partial class ProjectTaskController
    {
        [HttpPatch("assign-employees/{id}")]
        public async Task<ActionResult> AssignEmployees(int id, List<int> EmployeesIds)
        {
            var task = await UoW.projectTasks.GetById(id);
            if (task == null) return NotFound("La tarea no se encontró.");

            foreach (var employeeId in EmployeesIds)
            {
                Employee? e = await UoW.Employees.GetById(employeeId);
                if (e is null)
                    return NotFound($"El usuario con el id {employeeId} no existe. " +
                        $"Ningún cambio fue realizado.");
                task.Employees.Add(e);
            }

            await UoW.SaveAsync();
            return NoContent();
        }

        [HttpDelete("unassign-employees/{id}")]
        public async Task<ActionResult> UnassignEmployees(int id, List<int> EmployeesIds)
        {
            var task = await UoW.projectTasks.GetById(id);
            if (task is null) return NotFound("La tarea no se encontró.");

            foreach (var employeeId in EmployeesIds)
            {
                Employee? e = await UoW.Employees.GetById(employeeId);
                if (e == null)
                    return NotFound($"El usuario con el id {employeeId} no existe. " +
                        $"Ningún cambio fue realizado.");
                task.Employees.Remove(e);
            }

            await UoW.SaveAsync();
            return NoContent();
        }



    }

}
