using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace jk760216_MIS4200.Models
{
    public class LineItem
    {
        [Key]
        public int orderdetailID { get; set; }
        public int qtyOrdered { get; set; }
        public decimal price { get; set; }
        public int productID { get; set; }
        public int orderID { get; set; }
        public virtual Product product { get; set; }
        public virtual Order orders { get; set; }
    }
}