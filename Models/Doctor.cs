using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace jk760216_MIS4200.Models
{
    public class Doctor
    {
        [Key]
        
       public int doctorID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phone { get; set; }
        public ICollection<Appointments> Appointment { get; set; } 

    }
}