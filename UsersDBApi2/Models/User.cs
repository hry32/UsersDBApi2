﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace UsersDBApi2.Models
{
    public class User
    {        
            public int Id { get; set; }
            public string LastName { get; set; }
            public string FirstName { get; set; }
     
        public DateTime DateOfBirth { get; set; }




    }
}
