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
        [StringLength(100, ErrorMessage = "Name length can't be more than 100.")]   
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(1,999)]
        public decimal? Price { get; set; }

     

    }
}

