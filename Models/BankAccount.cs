using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RockApi.Enums;

namespace RockApi.Models
{
    /// <summary>
    /// Belongs to a household, created by a user.
    /// </summary>
    public class BankAccount
    {
        public int Id { get; set; }
        public int HouseHoldId { get; set; }
        public HouseHold HouseHold { get; set; }

        public string FPUserId { get; set; }
        public FPUser FPUser { get; set; }
        public string Name { get; set; }

        public AccountType Type { get; set; }

        public decimal StartingBalance { get; set; }
        public decimal? CurrentBalance { get; set; }
    }
}
