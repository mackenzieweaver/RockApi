using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RockApi.Models
{
    /// <summary>
    /// Alerts the head of household of important events.
    /// </summary>
    public class Notification
    {
        public int Id { get; set; }
        public int HouseHoldId { get; set; }
        public HouseHold HouseHold { get; set; }

        public DateTime Created { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

        public bool IsRead { get; set; }
    }
}
