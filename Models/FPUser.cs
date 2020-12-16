using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RockApi.Models
{
    /// <summary>
    /// Extends (inherits from) Microsoft's IdentityUser and adds the properties for first and last name, and an avatar.
    /// </summary>
    public class FPUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public byte[] FileData { get; set; }
        public string FileName { get; set; }

        public int? HouseHoldId { get; set; }
    }
}
