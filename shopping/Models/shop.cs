using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace shopping.Models
{
    public class shop
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string Pic { get; set; }
        public string Link { get; set; }
        public decimal Price { get; set; }
    }
    public class shopDBContext : DbContext
    {
        public DbSet<shop> shop { get; set; }
    }
}