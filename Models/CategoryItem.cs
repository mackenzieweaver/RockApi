using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RockApi.Models
{
    /// <summary>
    /// Belongs to a category, effectively creating a budget by listing items within a group.
    /// </summary>
    public class CategoryItem
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        
        public string Name { get; set; }
        public string Description { get; set; }
        
        public decimal TargetAmount { get; set; }
        public decimal ActualAmount { get; set; }
    }
}
