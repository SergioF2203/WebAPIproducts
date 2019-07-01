﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationProducts.Domain.Models;

namespace WebApplicationProducts.Domain.Services.Communication
{
    public class ProductResponse : BaseResponse
    {
        public Product Product { get; protected set; }

        private ProductResponse(bool success, string message, Product product): base(success, message)
        {
            Product = product;
        }

        public ProductResponse(Product product) : this(true, string.Empty, product) { }

        public ProductResponse(string message) : this(false, message, null) { }
    }
}
