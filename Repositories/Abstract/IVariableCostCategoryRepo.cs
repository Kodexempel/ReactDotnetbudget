using JohannasReactProject.Models;
using JohannasReactProject.Models.Entities;
using JohannasReactProject.Models.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JohannasReactProject.Repositories.Abstract
{
    public interface IVariableCostCategoryRepo
    {
        Task Post(VariableCostsCategories variableCostsCategories, string userId);
        Task Edit(EditVariableCostCategoryDTO editVariableCostCategoryDTO);
        IEnumerable<VariableCostCategoryDTO> Get(string userId);
    }
}
