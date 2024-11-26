using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Planify.Models;
using Planify.Repositories;
using Planify.Services;
using System.Collections.Generic;
using System.Threading.Tasks;
using static Planify.Services.Concurrency;

namespace Planify.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    // Get's:
    public partial class DepartmentsDeletedController : ControllerBase
    {
        private readonly IGenericCRUDRepository<Department, int> _department;

        public DepartmentsDeletedController(IGenericCRUDRepository<Department, int> department)
        {
            _department = department;
        }


        [HttpGet]
        public async Task<IEnumerable<Department>> Get() =>
            await _department.GetAll().ToListAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<Department>> GetById(int id)
        {
            Department? res = await _department.GetById(id);
            return res is not null ? res : NotFound();
        }
    }

    //POST & PUT
    public partial class DepartmentsDeletedController
    {
        [HttpPost]
        public async Task<IActionResult> Add(DepartmentDTO newDeparment)
        {
            Department? NewDepartment = await _department
                .Create(new Department { Name = newDeparment.Name });

            await _department.Save();

            if (NewDepartment is null)
                return StatusCode(500);

            return CreatedAtAction(nameof(Get), new { NewDepartment.Id }, NewDepartment);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, DepartmentDTO deparmentChanges)
        {
            var dep = await _department.GetById(id);
            if (dep is null)
                return NotFound();

            dep.Name = deparmentChanges.Name;
            _department.Updated(dep);

            ConcurrencyState state = await Concurrency.Check(() => _department.Save());

            if (state == ConcurrencyState.ConcurrencyDetected)
                return Conflict(new { message = ConflictMessage() });

            return NoContent();
        }

    }

    //Delete:
    public partial class DepartmentsDeletedController
    {
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            bool res = await _department.SoftDelete(id);
            await _department.Save();

            return res ? NoContent() : NotFound();
        }


        [HttpDelete("hardDelete/{id}")]
        public async Task<IActionResult> HardDelete(int id)
        {
            bool res = await _department.HardDelete(id);
            await _department.Save();

            return res ? NoContent() : NotFound();
        }

    }
}
