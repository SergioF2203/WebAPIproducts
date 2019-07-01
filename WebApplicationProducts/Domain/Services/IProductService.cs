using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationProducts.Domain.Models;
using WebApplicationProducts.Domain.Services.Communication;

namespace WebApplicationProducts.Domain.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> ListAsync();
        Task<ProductResponse> GetProductAsync(int id);
    }
}
