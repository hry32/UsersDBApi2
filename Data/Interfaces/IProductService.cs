using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Users.Data.Models;

namespace Users.Data.Interfaces
{
    public interface IProductService
    {
        Task<Product> CreateAsync(string name, string description, int rate);
        Task<Product> GetByIdAsync(int id);
        Task<IReadOnlyList<Product>> GetAllAsync();
    }
}
