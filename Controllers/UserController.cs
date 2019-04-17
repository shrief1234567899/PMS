using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using pms.Models;

namespace pms.Controllers
{
    public class UserController : Controller
    {
        public IActionResult CustomerHome()
        {
            return View("~/Views/Customer/Index.cshtml");
        }

         public IActionResult Profile()
        {
            return View("~/Views/User/Profile.cshtml");
        }
    }
}
