using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsersDBApi2.Models
{
    public class UserContext: DbContext
    {
        public UserContext(DbContextOptions<UserContext> options)
    : base(options)
        {
        }

        //public DbSet<User> UserItems { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
