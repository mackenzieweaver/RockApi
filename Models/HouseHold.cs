using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RockApi.Models
{
    public class HouseHold
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Greeting { get; set; }
        public DateTime Established { get; set; }
    }
}
