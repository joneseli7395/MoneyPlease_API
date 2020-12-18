using MoneyPlease_API.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyPlease_API.Models
{
    public class BankAccount
    {
        public int Id { get; set; }
        public int HouseholdId { get; set; }
        public Household Household { get; set; }

        public string FPUserId { get; set; }
        public FPUser FPUser { get; set; }

        public string Name { get; set; }

        [EnumDataType(typeof(AccountType))]
        public AccountType Type { get; set; }

        public decimal StartingBalance { get; set; }

        public decimal? CurrentBalance { get; set; }
    }
}
