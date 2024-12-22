using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Planify.Models;
using Planify.Repositories.UoW;
using Planify.Services;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Planify.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public partial class ProjectTaskCommentaryController : ControllerBase
    {
        private readonly IProjectManagement_UoW uow;
        public ProjectTaskCommentaryController(IProjectManagement_UoW uow) =>
            this.uow = uow;



        [HttpPost("{taskId}"), Authorize(Policy = PolicyNames.MinimumDeveloperOrViewer)]
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


        [HttpDelete("{taskId}"), Authorize(Policy = PolicyNames.MinimumDeveloper)]
        public async Task<ActionResult> DeleteComentary(int comentaryId)
        {
            if (!(Int32.TryParse(HttpContext.User?.Identity?.Name, out int userId)))
                return StatusCode(500);

            // Search comentary:
            var commentary = await uow.projectTasksComentaries.GetById(comentaryId);
            if (commentary is null)
                return NotFound("El comentario no existe");

            (bool isAuthorized, string? error) = await CanDelete(userId, commentary);
            if (!isAuthorized)
                return BadRequest(error);

            commentary.IsDeleted = true;
            await uow.SaveAsync();
            return NoContent();
        }


        [HttpGet("{id}"), Authorize(Policy = PolicyNames.MinimumDeveloperOrViewer)]
        public async Task<ActionResult<ProjectTaskComentary>> Get(int id)
        {
            ProjectTaskComentary? projectTask = await uow.projectTasksComentaries.GetById(id);
            return projectTask is null ? NotFound() : Ok(projectTask);
        }

    }

    //No endpoints
    public partial class ProjectTaskCommentaryController
    {
        private async Task<(bool, string? Error)> CanDelete(int userId, ProjectTaskComentary commentary)
        {
            var task = await uow.projectTasks.GetById(commentary.ProjectTaskId);
            if (task is null)
                return (false, "La tarea no existe");

            var project = await uow.projects.GetById(task.ProjectId);
            if (project is null)
                return (false, "El proyecto no existe.");

            if (IsAdminOrSA())
                return (true, null);

            if (userId == project.ManagerId)
                return (true, null);

            if (commentary.EmployeeId != userId)
                return (false, "No puedes eliminar un comentario que no te pertenece.");

            return (false, null);
        }

        private bool IsAdminOrSA() =>
           HttpContext.User.Claims
                .Any(c => c.Type == ClaimTypes.Role &&
                (c.Value.ToLower() == "sa" || c.Value.ToLower() == "admin"));


    }
}
