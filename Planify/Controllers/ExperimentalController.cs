using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Planify.Data;
using Planify.Models;
using Planify.Repositories;
using Planify.Services;
using System;
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
        [Authorize(Policy = PolicyNames.MinimumRhAdmin)]
        public string SA_ADMIN_RHADMIN() => "SA_ADMIN_RH-ADMIN";


        [HttpGet("ADMINorSA")]
        [Authorize(Policy = PolicyNames.MinimumAdmin)]
        public string ADMIN_SA() => "Admin or sa";



        [HttpGet("[action]")]
        [Authorize(Policy = PolicyNames.MinimumAdminOrViewer)]
        public string Admin_sa_viewer() => "Admin_sa_viewer";


        [HttpGet("[action]")]
        [Authorize(Policy = PolicyNames.MinimumRhAdminOrViewer)]
        public string RhAdmin_sa_viewer() => "RhAdmin_>>>>_viewer";

    }


    public partial class ExperimentalController
    {
        [AllowAnonymous]
        [HttpPost("timeonly")]
        public void prueba(TimeOnly tiempo)
        {
            Console.WriteLine(tiempo);
            Console.WriteLine("Extra:");
            Console.WriteLine(tiempo.Hour);
            Console.WriteLine(tiempo.Minute);
            Console.WriteLine(tiempo.Second);
            Console.WriteLine(tiempo.Microsecond);
            Console.WriteLine(tiempo.Nanosecond);
        }
        [AllowAnonymous]
        [HttpPost("datetimetest")]
        public void prueba(DateTime fecha)
        {
            Console.Clear();
            Console.WriteLine(fecha);
            Console.WriteLine("Fecha");
            Console.WriteLine(fecha.Year);
            Console.WriteLine(fecha.Month);
            Console.WriteLine(fecha.Day);
            Console.WriteLine("Extra:");
            Console.WriteLine(fecha.Hour);
            Console.WriteLine(fecha.Minute);
            Console.WriteLine(fecha.Second);
            Console.WriteLine(fecha.Microsecond);
            Console.WriteLine(fecha.Nanosecond);
        }
    }
}
