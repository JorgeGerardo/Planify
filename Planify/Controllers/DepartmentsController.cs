using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Planify.Data;
using Planify.Models;
using Planify.Repositories;

namespace Planify.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IGenericCRUDRepository<Department, int> _department;

        public DepartmentsController(IGenericCRUDRepository<Department, int> department)
        {
            _department = department;
        }

        [HttpPost]
        public async Task<IActionResult> Add(DepartmentDTO newDeparment)
        {
            Department departmentToCreate = new Department
            {
                Name = newDeparment.Name
            };

            Department? NewDepartment = await _department.Create(departmentToCreate);

            var x = (_department as DepartmentRepository);
            if (x is not null)
                await x.save();

            if (NewDepartment is null)
                return StatusCode(500);

            return Ok(NewDepartment);

        }

        [HttpGet]
        public async Task<IEnumerable<Department>> Get()
        {
            var res = await _department.GetAll().ToListAsync();

            var x = (_department as DepartmentRepository);
            if (x is not null)
                await x.save();

            return res;
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Department>> GetById(int id)
        {
            Department? res = await _department.GetById(id);
            return res is not null ? res : NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            bool res = await _department.SoftDelete(id);
            var x = (_department as DepartmentRepository);
            if (x is not null)
                await x.save();

            return res ? NoContent() : NotFound();
        }
        [HttpDelete("/hardDelete/{id}")]
        public async Task<IActionResult> HardDelete(int id)
        {
            bool res = await _department.HardDelete(id);
            var x = (_department as DepartmentRepository);
            if (x is not null)
                await x.save();

            return res ? NoContent() : NotFound();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, DepartmentDTO deparmentChanges)
        {
            var dep = await _department.GetById(id);
            if (dep is null)
                return NotFound();

            dep.Name = deparmentChanges.Name;
            _department.Updated(dep);


            var x = (_department as DepartmentRepository);
            if (x is not null)
                await x.save();

            return NoContent();
        }

    }
}
