using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationProducts.Domain.Models;

namespace WebApplicationProducts.Domain.Services.Communication
{
    public class SaveCategoryResponse : BaseResponse
    {
        public Category Category { get; protected set; }

        private SaveCategoryResponse(bool success, string message, Category category): base(success, message)
        {
            Category = category;
        }

        public SaveCategoryResponse(Category category) : this(true, string.Empty, category) { }

        public SaveCategoryResponse(string message) : this(false, message, null) { }
    }
}
