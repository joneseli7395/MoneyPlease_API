using MoneyPlease_API.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyPlease_API.Models
{
    public class Transaction
    {
        public int? CategoryItemId { get; set; }
        public CategoryItem CategoryItem { get; set; }

        public int BankAccountId { get; set; }
        public BankAccount BankAccount { get; set; }

        public string FPUserId { get; set; }
        public FPUser FPUser { get; set; }

        public DateTime Created { get; set; }

        [EnumDataType(typeof(TransactionType))]
        public TransactionType Type { get; set; }

        public string Memo { get; set; }

        public decimal Amount { get; set; }

        public bool IsDeleted { get; set; }
    }
}
