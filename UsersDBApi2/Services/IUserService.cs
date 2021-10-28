using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsersDBApi2.Models;

namespace UsersDBApi2.Services
{
    public interface IUserService
    {
        Task<IEnumerable<User>> Get();
        Task<User> Get(int id);
        Task<User> Create(User user);
        Task Update(User user);
        Task Delete(int id);
    }
}
