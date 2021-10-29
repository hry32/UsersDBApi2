﻿using System;
using System.Collections.Generic;
using System.Text;
using Users.Data.Contracts;

namespace Users.Data.Models
{
    public class Product : BaseEntity, IMustHaveTenant
    {
        public Product(string name, string description, int rate)
        {
            Name = name;
            Description = description;
            Rate = rate;
        }
        protected Product()
        {
        }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public int Rate { get; private set; }
        public string TenantId { get; set; }
    }
}
