using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationProducts.Domain.Models;

namespace WebApplicationProducts.Domain.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
    }
}
