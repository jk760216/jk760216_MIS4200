using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Web;

namespace jk760216_MIS4200.Models
{
    public class Product
    {
        public int productID { get; set; }
        public string description { get; set; }
        public decimal unitCost { get; set; }
        public ICollection<LineItem> lineitem { get; set; }
        public int supplierID { get; set; }
    }
}