using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProductsProject.Models
{
    [Table("Product")]
    public class Product
    {  
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual Category Category { get; set;}
        public int CategoryId { get; set; }
    }
}