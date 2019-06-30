using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationProducts.Resources
{
    public class ProductResource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public CategoryResource Category { get; set; }
    }
}
