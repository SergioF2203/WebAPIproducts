using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationProducts.Resources
{
    public class SaveProductResource
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]
        public double Price { get; set; }

        public int CategoryId { get; set;} 
        public bool IsActive { get; set; }

    }
}
