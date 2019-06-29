using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationProducts.Domain.Models;

namespace WebApplicationProducts.Domain.Services.Communication
{
    public class CategoryResponse : BaseResponse
    {
        public Category Category { get; protected set; }

        private CategoryResponse(bool success, string message, Category category): base(success, message)
        {
            Category = category;
        }

        public CategoryResponse(Category category) : this(true, string.Empty, category) { }

        public CategoryResponse(string message) : this(false, message, null) { }
    }
}
