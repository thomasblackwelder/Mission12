using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission12.Models
{
    public class Group
    {
        [Key]
        [Required]
        public long GroupId { get; set; }
        
        [Required]
        public long AppointmentId { get; set; }
        
        public Appointment Appointment { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        public int Size { get; set; }
        
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        
        public string Phone { get; set; }
    }

}
