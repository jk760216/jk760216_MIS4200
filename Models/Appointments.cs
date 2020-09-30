using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace jk760216_MIS4200.Models
{
    public class Appointments
    {
        [Key]
        public int AppointmentID { get; set; }
        public DateTime time { get; set; }
        public int patientID { get; set; }
        public virtual Patient Patient { get; set; }
        public int doctorID { get; set; }
        public virtual Doctor Doctor { get; set; }
    }
}