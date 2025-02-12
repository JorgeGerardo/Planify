﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Planify.Models;
using Planify.Repositories;
using Planify.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Planify.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public partial class ProjectsController : GenericController<Project, ProjectRepository, ProjectCreateDTO, ProjectUpdateDTO>
    {
        private readonly IGenericCRUDRepository<Project, int> _repository;
        private readonly IGenericCRUDRepository<Employee, int> _employeeRepository;
        public ProjectsController(
            IGenericCRUDRepository<Project, int> repository,
            IGenericCRUDRepository<Employee, int> employeeRepository
        ) : base(repository)
        {
            _repository = repository;
            _employeeRepository = employeeRepository;
        }
    }

    //Maps:
    public partial class ProjectsController
    {
        //Create:
        protected override Project MapToEntity(ProjectCreateDTO dto) =>
            MapToEntityAsync(dto).GetAwaiter().GetResult();

        protected override async Task<Project> MapToEntityAsync(ProjectCreateDTO dto)
        {
            bool existEmployee = await _employeeRepository.ExistAsync(e => e.Id.Equals(dto.ManagerId));

            if (!existEmployee)
                throw new Exception("El adminsitrador asignado no existe. Consulte la información.");

            return new Project
            {
                Name = dto.Name,
                ManagerId = dto.ManagerId,
            };
        }

        //Update:
        protected override Project MapToUpdateEntity(Project currentState, ProjectUpdateDTO dto) =>
            MapToUpdateEntityAsync(currentState, dto).GetAwaiter().GetResult();

        protected async override Task<Project> MapToUpdateEntityAsync(Project currentState, ProjectUpdateDTO dto)
        {
            if (dto.ManagerId is not null && dto.ManagerId != currentState.ManagerId)
            {
                bool EmployeeExist = await _employeeRepository.ExistAsync(e => e.Id.Equals(dto.ManagerId));

                if (!EmployeeExist)
                    throw new Exception("El nuevo administrador proporcionado no existe.");

                currentState.ManagerId = dto.ManagerId.Value;
            }
            currentState.Name = dto.Name;

            return currentState;
        }
    }


    public partial class ProjectsController
    {
        [Authorize(Policy = PolicyNames.MinimumManagerOrViewer)]
        public override Task<IEnumerable<Project>> Get(int page = 0, int? pageSize = null) =>
            base.Get(page, pageSize);

        [Authorize(Policy = PolicyNames.MinimumManagerOrViewer)]
        public override Task<ActionResult<Project>> GetById(int id) =>
            base.GetById(id);

        [Authorize(Policy = PolicyNames.MinimumManager)]
        public override Task<IActionResult> Update(int id, ProjectUpdateDTO createDto) =>
            base.Update(id, createDto);

        [Authorize(Policy = PolicyNames.MinimumManager)]
        public override Task<IActionResult> Add([FromBody] ProjectCreateDTO createDto) =>
            base.Add(createDto);


        [Authorize(Policy = PolicyNames.MinimumAdmin)]
        public override Task<IEnumerable<Project>> GetWithoutFiltters(int page = 0, int? pageSize = null) =>
            base.GetWithoutFiltters(page, pageSize);

        [Authorize(Policy = PolicyNames.MinimumManager)]
        public override Task<IActionResult> Delete(int id) =>
            base.Delete(id);

    }


    //Add-remove employees
    public partial class ProjectsController
    {
        [HttpPatch("Add-Employees/{id}")]
        [Authorize(Policy = PolicyNames.MinimumManager)]
        public async Task<ActionResult> AddEmployees(int id, List<int> EmployeesIds)
        {
            Project? project = await _repository.GetById(id);

            if (project is null)
                return NotFound(new ProblemDetails { Detail = "El proyecto no existe" });

            List<Employee> employees = new List<Employee>();
            foreach (var employeeId in EmployeesIds)
            {
                Employee? employee = await _employeeRepository.GetById(employeeId);

                if (employee is null)
                    return BadRequest(new ProblemDetails 
                    { Detail = $"El empleado con el id {employeeId} no existe." });

                project.Employees.Add(employee);
            }

            await _employeeRepository.Save();
            return NoContent();
        }

        [HttpPatch("Remove-Employees/{id}")]
        [Authorize(Policy = PolicyNames.MinimumManager)]
        public async Task<ActionResult> RemoveEmployees(int id, List<int> EmployeesIds)
        {
            Project? project = await _repository.GetById(id);

            if (project is null)
                return NotFound(new ProblemDetails { Detail = "El proyecto no existe"});

            List<Employee> employees = new List<Employee>();
            foreach (var employeeId in EmployeesIds)
            {
                Employee? employee = await _employeeRepository.GetById(employeeId);

                if (employee is null)
                    return BadRequest(new ProblemDetails 
                    { Detail = $"El empleado con el id {employeeId} no existe." });

                project.Employees.Remove(employee);
            }

            await _employeeRepository.Save();
            return NoContent();
        }

    }

    //User projects
    public partial class ProjectsController
    {
        [HttpGet("my-projects")]
        [Authorize(Policy = PolicyNames.MinimumDeveloper)]
        public async Task<ActionResult<List<Project>>> GetMyProjects()
        {
            if (!(Int32.TryParse(HttpContext.User?.Identity?.Name, out int UserId)))
                return StatusCode(500);

            return await _repository.GetAll()
                .Where(p => p.Employees.Any(p => p.Id == UserId))
                .ToListAsync();
        }


        [HttpGet("user-projects/{userId}")]
        [Authorize(Policy = PolicyNames.MinimumManagerOrViewer)]
        public async Task<ActionResult<List<Project>>> GetUserProjects(int userId) =>
            await _repository.GetAll()
                .Where(p => p.Employees.Any(p => p.Id == userId)).ToListAsync();

    }
}
