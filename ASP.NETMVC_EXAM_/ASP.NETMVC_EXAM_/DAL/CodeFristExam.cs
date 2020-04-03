using ASP.NETMVC_EXAM_VU.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASP.NETMVC_EXAM_VU.DAL
{
    public class CodeFristExam : DbContext
    {
        public CodeFristExam() : base("CodeFristExam")
        {
        
        } 
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}