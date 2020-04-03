using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NETMVC_EXAM_VU.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int SupplierId { get; set; }
        public int CategoryID { get; set; }
        public int QuantityPerUnit { get; set; }
        public int UnitsOnOrder { get; set; }
        public string ReOrderLevel { get; set; }
        public bool Discountined { get; set; }

        public Category Category { get; set; }
    }
}