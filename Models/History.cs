using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RockApi.Models
{
    /// <summary>
    /// Snapshot of a bank account's balance at the end of a day if new transactions were made.
    /// </summary>
    public class History
    {
        public int Id { get; set; }
        public int BankAccountId { get; set; }
        public BankAccount BankAccount { get; set; }
        public decimal Balance { get; set; }
        public DateTime Date { get; set; }
    }
}
