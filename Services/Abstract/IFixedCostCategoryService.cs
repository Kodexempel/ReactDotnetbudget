using JohannasReactProject.Models.Entities;
using JohannasReactProject.Models.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JohannasReactProject.Services.Abstract
{
    public interface IFixedCostCategoryService
    {
        Task Post(FixedCostsCategories fixedCostsCategories, string userId);
        Task Edit(EditFixedCostCategoryDTO editFixedCostCategoryDTO);
        IEnumerable<FixedCostCategoryDTO> Get(string userId);
    }
}
