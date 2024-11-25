using Microsoft.AspNetCore.Mvc;
using Planify.Models;
using Planify.Repositories;

namespace Planify.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public partial class DepartmentsController2 : GenericController<Department, DepartmentRepository>
    {
        public DepartmentsController2(IGenericCRUDRepository<Department, int> department) : base(department) { }

    }

    //POST & PUT
    public partial class DepartmentsController2
    {
        //[HttpPost]
        //public async Task<IActionResult> Add(DepartmentDTO newDeparment)
        //{
        //    Department? NewDepartment = await _department
        //        .Create(new Department { Name = newDeparment.Name });

        //    await _department.Save();

        //    if (NewDepartment is null)
        //        return StatusCode(500);

        //    return CreatedAtAction(nameof(Get), new { NewDepartment.Id }, NewDepartment);
        //}

        //[HttpPut("{id}")]
        //public async Task<IActionResult> Update(int id, DepartmentDTO deparmentChanges)
        //{
        //    var dep = await _department.GetById(id);
        //    if (dep is null)
        //        return NotFound();

        //    dep.Name = deparmentChanges.Name;
        //    _department.Updated(dep);

        //    ConcurrencyState state = await Concurrency.Check(() => _department.Save());

        //    if (state == ConcurrencyState.ConcurrencyDetected)
        //        return Conflict(new { message = ConflictMessage() });

        //    return NoContent();
        //}

    }

}
