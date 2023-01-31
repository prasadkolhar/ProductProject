using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace ProductsProject.Models
{
    public class ContextClass:DbContext
    {
        public ContextClass() : base("name=cs") 
        {
        }
        public DbSet<Product> Products { get; set;}
        public DbSet<Category> Categories { get; set;}
    }
}