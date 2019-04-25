using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using pms.Models;

namespace pms.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        public ActionResult GetProject()
        {
            return Json(new {status="200", data="Blech" , displaySweetAlert=false});
        }
    }
}
