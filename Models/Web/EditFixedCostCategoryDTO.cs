using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JohannasReactProject.Models.Web
{
    public class EditFixedCostCategoryDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Sum { get; set; }
        public decimal Cost { get; set; }
    }
}
