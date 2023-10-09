using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JohannasReactProject.Models.Web
{
    public class SavingGoalDTO
    {
        public Guid Id { get; set; }
        public decimal ToSave { get; set; }
        public string Name { get; set; }
        public decimal Saved { get; set; }
    }
}
