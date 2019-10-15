using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CoffeMugApplicationProject.Models
{
    public class Product
    {
        
        public Guid Id { get; set; }
        [StringLength(100)]
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }

     

    }
}

