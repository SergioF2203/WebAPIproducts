using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationProducts.Domain.Models;
using WebApplicationProducts.Domain.Repositories;
using WebApplicationProducts.Domain.Services;

namespace WebApplicationProducts.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<Product>> ListAsync()
        {
            return await _productRepository.ListAsync();
        }
    }
}
