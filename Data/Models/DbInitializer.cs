using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Users.Data;

namespace Users.Data.Models
{
    public static class DbInitializer
    {
        public static void Initialize(UserContext context)
        {
            context.Database.EnsureCreated();

            // Look for any users.
            if (context.Users.Any())
            {
                return;   // DB has been seeded
            }

            var users = new User[]
            {
            new User{FirstName="Roman",LastName="Harmatiuk",DateOfBirth=DateTime.Parse("1985-05-20")},
            new User{FirstName="Pavlo",LastName="Kozlov",DateOfBirth=DateTime.Parse("1965-12-12")},
            new User{FirstName="Semen",LastName="Kapusta",DateOfBirth=DateTime.Parse("2005-08-07")},
            new User{FirstName="Petro",LastName="Stepanov",DateOfBirth=DateTime.Parse("1986-10-01")},
            new User{FirstName="Bogdan",LastName="Amosov",DateOfBirth=DateTime.Parse("1976-02-23")},

            };
            foreach (User s in users)
            {
                context.Users.Add(s);
            }
            context.SaveChanges();
        }
    }
}
