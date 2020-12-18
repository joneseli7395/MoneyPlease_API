using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyPlease_API.Models
{
    public class FPUser 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName { get { return $"{FirstName} {LastName}"; } }

        public int? HouseholdId { get; set; }
        public Household Household { get; set; }
    }
}
