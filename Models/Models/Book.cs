using System;
using System.Collections.Generic;
using System.Text;

namespace Users.Domain.Models
{
    class Book
    {
            public int Id { get; set; }
            public string LastName { get; set; }
            public string FirstName { get; set; }

            public DateTime DateOfBirth { get; set; }
        }
}
