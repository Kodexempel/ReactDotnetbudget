using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JohannasReactProject.Models.Entities
{
    public class SavingGoal : Entity
    {
        public decimal ToSave { get; set; }
        public string Name { get; set; }
        public decimal Saved { get; set; }
        public virtual ApplicationUser User { get; set; }

    }
}
