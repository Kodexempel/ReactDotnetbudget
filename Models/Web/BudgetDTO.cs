using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JohannasReactProject.Models.Web
{
    public class BudgetDTO
    {
        public Guid Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Income { get; set; }
        public decimal Unbudgeted { get; set; }
        public virtual ICollection<FixedCostCategoryDTO> fixedCostCategoryDTO { get; set; }
    }
}
