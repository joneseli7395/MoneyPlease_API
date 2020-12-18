﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyPlease_API.Models
{
    public class Category
    {
        public int Id { get; set; }
        public int HouseholdId { get; set; }
        public Household Household { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
