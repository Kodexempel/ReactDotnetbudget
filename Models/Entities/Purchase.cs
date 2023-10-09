using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JohannasReactProject.Models.Entities
{
    public class Purchase : Entity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
        public virtual ApplicationUser User { get; set; }
        public VariableCostsCategories VariableCostsCategory { get; set; }
    }
}
