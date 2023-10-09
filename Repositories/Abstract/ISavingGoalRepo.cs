using JohannasReactProject.Models.Entities;
using JohannasReactProject.Models.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JohannasReactProject.Repositories.Abstract
{
    public interface ISavingGoalRepo
    {
        Task Post(SavingGoal savingGoal, string userId);
        Task Edit(EditSavingGoalDTO editSavingGoalDTO);
        IEnumerable<SavingGoalDTO> Get(string userId);
    }
}
