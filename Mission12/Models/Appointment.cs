﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission12.Models
{
    public class Appointment
    {
      public long AppointmentId { get; set; }
      public DateTime Time { get; set; }
      public Boolean Available { get; set; }  
    }
}
