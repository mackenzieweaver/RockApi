using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RockApi.Models
{
    /// <summary>
    /// Belongs to a household and represents a budget group.
    /// </summary>
    public class Category
    {
        public int Id { get; set; }
        public int HouseHoldId { get; set; }
        public HouseHold HouseHold { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
