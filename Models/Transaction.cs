using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RockApi.Enums;

namespace RockApi.Models
{
    /// <summary>
    /// The nucleas that the application revolves around. Categories and their item amounts are based on the total spent on them from transaction records.
    /// </summary>
    public class Transaction
    {
        public int Id { get; set; }

        public int? CategoryItemId { get; set; }
        public CategoryItem CategoryItem { get; set; }

        public int BankAccountId { get; set; }
        public BankAccount BankAccount { get; set; }

        public string FPUserId { get; set; }
        public FPUser FPUser { get; set; }

        public DateTime Created { get; set; }
        public TransactionType Type { get; set; }

        public string Memo { get; set; }
        public decimal Amount { get; set; }

        public bool IsDeleted { get; set; }
    }
}
