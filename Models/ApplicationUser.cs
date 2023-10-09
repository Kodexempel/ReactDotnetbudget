using JohannasReactProject.Models.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JohannasReactProject.Models
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ICollection<Budget> Budget { get; set; }
        public virtual ICollection<SavingGoal> SavingGoals { get; set; }
        public virtual ICollection<VariableCostsCategories> VariableCostsCategories { get; set; }
        public virtual ICollection<FixedCostsCategories> FixedCostsCategories { get; set; }
        public virtual ICollection<Purchase> Purchases { get; set; }

    }
}
