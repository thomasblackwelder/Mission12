using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission12.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission12.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }


        /// This code below needs to be fixed 
        public IActionResult ViewAppointments()
        {
            var appts = context.groups
                .Include(x => x.Group)

            return View();
        }


    }
}
