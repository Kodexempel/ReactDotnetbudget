using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JohannasReactProject.Models.Entities
{
    public class BudgetCategory : Entity
    {
        public virtual Budget Budget { get; set; }
        
        public virtual VariableCostsCategories VariableCostsCategory { get; set; }
        public decimal MaxSpent { get; set; }
    }

    public class VariableCostsCategories : Entity
    {
        public string Name { get; set; }
        public decimal ToSpend { get; set; }
        public decimal Spent { get; set; }
        public virtual ICollection<BudgetCategory> BudgetCategories { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual ICollection<Purchase> Purchases { get; set; }
         
    }

    public class FixedCostsCategories : Entity
    {
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public virtual ICollection<Budget> Budget { get; set; }
        public virtual ApplicationUser User { get; set; }

    }
}
