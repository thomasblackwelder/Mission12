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

        private GroupContext context { get; set; }

        public HomeController(GroupContext temp)
        {
            context = temp;
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


        public IActionResult SignUp()
        {
            var appts = context.Appointments
                .Where(x => x.Available == true)
                .ToList();
            return View(appts);
        }


    }
}
