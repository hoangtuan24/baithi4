using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace ASP.NETMVC_EXAM_VU.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Desception { get; set; }
        public string Picture { get; set; }

        public ICollection<Product> Products { get; set; }

    }
}