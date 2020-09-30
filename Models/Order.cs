using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jk760216_MIS4200.Models
{
    public class Order
    {
        public int orderID { get; set; }
        public string description { get; set; }
        public DateTime orderDate { get; set; }
        public int customerID { get; set; }

        public virtual Customer customer { get; set; }
        public ICollection<LineItem> LineItem { get; set; }

    }
}