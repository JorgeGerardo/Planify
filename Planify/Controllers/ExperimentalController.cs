using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Planify.Data;
using Planify.Models;
using Planify.Repositories;
using Planify.Services;
using System.Linq;
using System.Threading.Tasks;

namespace Planify.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public partial class ExperimentalController : ControllerBase
    {
        ProjectContext _context;
        IGenericCRUDRepository<Person, int> _personContext;
        public ExperimentalController(ProjectContext context, IGenericCRUDRepository<Person, int> personscontext)
        {
            _context = context;
            _personContext = personscontext;
        }
            //_context = context;

        [HttpGet("[action]")]
        public async Task sssssssss()
        {
            var x = await _personContext.GetById(1);
        }


    }


    public partial class ExperimentalController
    {
        //sa works
        [HttpGet("sa")]
        [Authorize(Policy = "sa")]
        public string show2() => "sa";

        //admin works
        [HttpGet("admin")]
        [Authorize(Policy = "admin")]
        public string admin() => "admin";

        //manager works
        [HttpGet("manager")]
        [Authorize(Policy = "manager")]
        public string pj_manager() => "manager";

        //rh-admin works
        [HttpGet("rh-admin")]
        [Authorize(Policy = "rh-admin")]
        public string rh_admin() => "rh-admin";

        //rh works
        [HttpGet("rh")]
        [Authorize(Policy = "rh")]
        public string rh() => "rh";

        //viewer works
        [HttpGet("viewer")]
        [Authorize(Policy = "viewer")]
        public string viewer() => "viewer";


        /////////////////////////////////////////////////////////////////////////////////
        //Combinated:
        [HttpGet("SAorAdmin")]
        [Authorize(Policy = "SAorAdmin")]
        public string show() => "SAorAdmin";


        [HttpGet("SA_ADMIN_RH-ADMIN")]
        [Authorize(Policy = PolicyNames.RhAdmin_Admin_SA)]
        public string SA_ADMIN_RHADMIN() => "SA_ADMIN_RH-ADMIN";

    }
}
