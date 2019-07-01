using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationProducts.Domain.Models;
using WebApplicationProducts.Domain.Services;
using WebApplicationProducts.Resources;

namespace WebApplicationProducts.Controllers
{
    [Route("/api/[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }
        // GET: Product
        [HttpGet]
        public async Task<IEnumerable<ProductResource>>ListAsync()
        {
            var products = await _productService.ListAsync();
            var resources = _mapper.Map<IEnumerable<Product>, IEnumerable<ProductResource>> (products);

            return resources;
        }

        //GET: Product/id
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductAsync(int id)
        {
            var result = await _productService.GetProductAsync(id);

            if (!result.Success)
                return BadRequest(result.Message);

            var productResource = _mapper.Map<Product, ProductResource>(result.Product);
            return Ok(productResource);
        }
    }
}