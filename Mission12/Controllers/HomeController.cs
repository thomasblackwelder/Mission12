using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        public IActionResult ViewAppointments()
        {
            //var appts = context.Appointments
            //    .Where(y => y.Available == false)
            //    .Include(x => x.Group)
            //    .ToList();
            //return View(appts);


            var appts = context.Groups
                .Include(x => x.Appointment)
                .Where(y => y.Appointment.Available == false)
                .ToList();
               return View(appts);
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
