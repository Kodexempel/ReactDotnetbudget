using JohannasReactProject.Models;
using JohannasReactProject.Models.Entities;
using JohannasReactProject.Models.Web;
using JohannasReactProject.Repositories.Abstract;
using JohannasReactProject.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JohannasReactProject.Services.Concrete
{
    public class VariableCostCategoryService : IVariableCostCategoryService

    {
        private readonly IVariableCostCategoryRepo _variableCostCategoryRepo;
        public VariableCostCategoryService(IVariableCostCategoryRepo variableCostCategoryRepo) => _variableCostCategoryRepo = variableCostCategoryRepo;
        public async Task Edit(EditVariableCostCategoryDTO editVariableCostCategoryDTO)
        {
            await _variableCostCategoryRepo.Edit(editVariableCostCategoryDTO);
        }

        public IEnumerable<VariableCostCategoryDTO> Get(string userId)
        {
           return _variableCostCategoryRepo.Get(userId);
        }

        public async Task Post(VariableCostsCategories variableCostsCategories, string userId)
        {
            await _variableCostCategoryRepo.Post(variableCostsCategories, userId);
        }
    }
}
