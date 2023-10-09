using JohannasReactProject.Models;
using JohannasReactProject.Models.Entities;
using JohannasReactProject.Models.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JohannasReactProject.Repositories.Abstract
{
    public interface IBudgetRepo
    {
        Task Post(Budget budget, string userId);
        Task Edit(EditBudgetDTO budget);
        IEnumerable<BudgetDTO> Get(string userId);
    }
}
