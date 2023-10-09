using JohannasReactProject.Models;
using JohannasReactProject.Models.Entities;
using JohannasReactProject.Models.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JohannasReactProject.Services.Abstract
{
    public interface IBudgetService
    {
        Task Post(Budget budget, string userId);
        Task Edit(EditBudgetDTO budget);
        IEnumerable<BudgetDTO> Get(string userId);
    }
}
