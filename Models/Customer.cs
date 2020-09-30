using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jk760216_MIS4200.Models
{
    public class Customer
    {
        public int customerID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public DateTime customerSince { get; set; }
    }
}