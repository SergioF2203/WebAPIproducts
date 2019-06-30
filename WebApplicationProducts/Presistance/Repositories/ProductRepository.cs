using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationProducts.Domain.Models;
using WebApplicationProducts.Domain.Repositories;
using WebApplicationProducts.Presistance.Contexts;

namespace WebApplicationProducts.Presistance.Repositories
{
    public class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context) { }

        public async Task<IEnumerable<Product>> ListAsync()
        {
            return await _context.Products.Include(p => p.Category).ToListAsync();
        }
    }
}
