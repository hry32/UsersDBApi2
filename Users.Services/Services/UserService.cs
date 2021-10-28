using Users.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Users.Services;

namespace Users.Services.Services
{
 
        public class Userservice : IUserService
        {
            private readonly UserContext _context;

            public Userservice(UserContext context)
            {
                _context = context;
            }
            public async Task<User> Create(User user)
            {
                _context.Users.Add(user);
                await _context.SaveChangesAsync();

                return user;
            }

            public async Task Delete(int id)
            {
                var userToDelete = await _context.Users.FindAsync(id);
                _context.Users.Remove(userToDelete);
                await _context.SaveChangesAsync();
            }

            public async Task<IEnumerable<User>> Get()
            {
                return await _context.Users.ToListAsync();
            }

            public async Task<User> Get(int id)
            {
                return await _context.Users.FindAsync(id);
            }

            public async Task Update(User user)
            {
                _context.Entry(user).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
        }
    
}
