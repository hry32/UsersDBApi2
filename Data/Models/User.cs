using System;
using System.Collections.Generic;
using System.Text;
using Users.Data.Contracts;

namespace Users.Data.Models
{
    public class User
    {
         public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}
