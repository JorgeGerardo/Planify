using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Planify.Models;
using Planify.Repositories.UoW;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Planify.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProjectTaskComentaryController : ControllerBase
    {
        private readonly IProjectManagement_UoW uow;
        public ProjectTaskComentaryController(IProjectManagement_UoW uow) =>
            this.uow = uow;


        [HttpPost("{taskId}")]
        public async Task<ActionResult> Get(ProjectTaskComentaryCreateDTO dto, int taskId)
        {
            string? userId = HttpContext.User?.Identity?.Name;
            if (userId is null)
                return NotFound("Usuario no encontrado.");

            ProjectTask? projectTask = await uow.projectTasks.GetById(taskId);
            if (projectTask is null)
                return NotFound("La tarea no existe.");

            bool employeeIsIn = projectTask.Employees.Any(c => c.Id.ToString().Equals(userId));
            if (!employeeIsIn)
                return BadRequest($"El usuario {userId} no tiene asignada esta tarea.");

            ProjectTaskComentary newComentary = new ProjectTaskComentary
            {
                Comentary = dto.Comentary,
                EmployeeId = Convert.ToInt32(userId),
                ProjectTaskId = taskId
            };
            projectTask.Comentaries.Add(newComentary);


            await uow.SaveAsync();
            return NoContent();
        }

        [HttpDelete("{employeeId}/{taskId}")]
        public async Task<ActionResult> DeleteComentary(int taskId, int employeeId)
        {
            var task = await uow.projectTasks.GetById(taskId);
            if (task is null)
                return NotFound();


            var comentary = await uow.projectTasksComentaries.GetById(taskId);
            if (comentary is null)
                return NotFound("El comentario no existe");



            comentary.IsDeleted = true;
            await uow.SaveAsync();

            return NoContent();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<ProjectTaskComentary>> Get(int id)
        {
            ProjectTaskComentary? projectTask = await uow.projectTasksComentaries.GetById(id);
            return projectTask is null? NotFound() : Ok(projectTask);
        }

    }
}
