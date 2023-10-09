using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JohannasReactProject.Models.Entities
{
    public class Balance : Entity
    {
        public virtual ICollection<BalanceChanged> BalanceChanges { get; set; }
       public decimal Sum { get; set; }
        public virtual ApplicationUser User { get; set; }

    }

    public class BalanceChanged : Entity
    {
        public decimal OldSum { get; set; }
        public decimal NewSum { get; set; }
        public DateTime Date { get; set; }
        public Balance Balance { get; set; }
        public virtual ApplicationUser User { get; set; }

    }
}
