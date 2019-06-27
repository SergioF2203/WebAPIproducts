using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationProducts.Domain.Models;

namespace WebApplicationProducts.Domain.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> ListAsync();
    }
}
