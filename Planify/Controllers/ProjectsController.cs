using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Planify.Models;
using Planify.Repositories;
using System;
using System.Collections.Generic;
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

    //TODO: Deberías hacer un endpoint especifico para eliminar o agregar empleados a un proyecto
    public partial class ProjectsController
    {
        [HttpGet("Prueba")]
        public async Task<Object> getprueba()
        {
            return await _repository.GetAll().Include(p => p.Employees).ToListAsync();
        }

        [HttpGet("Add-Employee/{id}")]
        public async Task<Object> addEmployee(int id, List<int> EmployeesIds)
        {
            return await _repository.GetAll().Include(p => p.Employees).ToListAsync();
        }
    }
}
