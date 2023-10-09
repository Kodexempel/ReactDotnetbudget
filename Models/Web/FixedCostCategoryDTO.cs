using JohannasReactProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JohannasReactProject.Models.Web
{
    public class FixedCostCategoryDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public virtual Budget Budget { get; set; }
    }
}
