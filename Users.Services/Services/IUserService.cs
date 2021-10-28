using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Users.Data.Models;

namespace Users.Services.Services

{
    public interface IUserService
    {

            public Task<IEnumerable<User>> Get();
            public Task<User> Get(int id);
            public Task<User> Create(User user);
            public Task Update(User user);
            public Task Delete(int id);
        
    }
}
