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

        [HttpGet]
        public IActionResult GroupForm (long a)
        {
            ViewBag.Appt = a;
            ViewBag.GID = 0;
            return View();
        }

        [HttpPost]
        public IActionResult GroupForm (Group g)
        {
            if (ModelState.IsValid)
            {
                context.Add(g);
                context.Appointments.Single(x => x.AppointmentId == g.AppointmentId).Available = false;
                context.SaveChanges();
 
                return RedirectToAction("ViewAppointments");
            }
            else
            {
                return View();
            }
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

        [HttpGet]
        public IActionResult Edit(long appointmentId)
        {
           //var blah = context.Appointments.ToList();

            var groupInfo = context.Groups.Single(x => x.AppointmentId == appointmentId);
            ViewBag.Appt = appointmentId;
            ViewBag.GID = groupInfo.GroupId;


            return View("GroupForm", groupInfo);
        }

        [HttpPost]


        public IActionResult Edit(Group blah )

        {
            context.Update(blah);
            context.SaveChanges();


            return RedirectToAction("ViewAppointments");


        }


        ////I dont think we need this get method actually since we dont have a delete page but we could build one (T.B.)
        //[HttpGet]
        //public IActionResult Delete(long appointmentId)
        //{
        //    var appointment = context.Appointments.Single(x => x.AppointmentId == appointmentId);
        //    return View(appointment);
        //}


        ///Should the delete method just change available from T to F rather than remove the whole appointment? (T.B.)


   

        
        public IActionResult Delete(long grpId)

        {
            var grp = context.Groups.Single(x => x.GroupId == grpId);
            context.Appointments.Where(x => x.AppointmentId == grp.AppointmentId).FirstOrDefault().Available = true;
            context.Groups.Remove(grp);
            context.SaveChanges();
            return RedirectToAction("ViewAppointments");
        }


        [HttpGet]
        public IActionResult SignUp(string showdate = "03/27/2022")

        {
            DateTime oDate = Convert.ToDateTime(showdate);
            var appts = context.Appointments
                .Where(x => x.Available == true)
                .Where(x => x.Time.Date == oDate)
                .ToList();
            return View(appts);
        }
    }
}
