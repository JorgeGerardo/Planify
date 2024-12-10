using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Planify.Data;

namespace Planify.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExperimentalController : ControllerBase
    {
        ProjectContext _context;
        public ExperimentalController(ProjectContext context) =>
            _context = context;

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



    }

}
