using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Planify.Models;
using Planify.Repositories;
using System;
using System.Threading.Tasks;

namespace Planify.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public partial class ProjectsController : GenericController<Models.Project, ProjectRepository, ProjectDTO, ProjectDTO>
    {
        private readonly IGenericCRUDRepository<Models.Project, int> _repository;
        public ProjectsController(IGenericCRUDRepository<Models.Project, int> repository) : base(repository) 
        {
            _repository = repository;
        }



        protected override Models.Project MapToEntity(ProjectDTO dto)
        {
            return new Models.Project
            {
                Name = dto.Name,
            };
        }

        protected override Models.Project MapToUpdateEntity(Models.Project currentState, ProjectDTO dto)
        {
            currentState.Name = dto.Name;
            return currentState;
        }
    }

    public partial class ProjectsController : GenericController<Models.Project, ProjectRepository, ProjectDTO, ProjectDTO>
    {
        [HttpGet("Prueba")]
        public async Task<Object> getprueba()
        {
            return await _repository.GetAll().Include(p => p.Employees).ToListAsync();
        }
    }
}
