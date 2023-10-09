using JohannasReactProject.Data;
using JohannasReactProject.Models.Entities;
using JohannasReactProject.Models.Web;
using JohannasReactProject.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JohannasReactProject.Repositories.Concrete
{
    public class FixedCostCategoryRepo : IFixedCostCategoryRepo
    {
        private readonly ApplicationDbContext _context;

        public FixedCostCategoryRepo(ApplicationDbContext context) => _context = context;
        public async Task Edit(EditFixedCostCategoryDTO editFixedCostCategoryDTO)
        {
            var foundCategory = _context.FixedCostsCategories.Where(x => x.Id == editFixedCostCategoryDTO.Id).FirstOrDefault();

            foundCategory.Name = editFixedCostCategoryDTO.Name;
            foundCategory.Cost = editFixedCostCategoryDTO.Cost;

            await _context.SaveChangesAsync();
        }

        public IEnumerable<FixedCostCategoryDTO> Get(string userId)
        {
            var returnList = new List<FixedCostCategoryDTO>();
            var fixedCostCateogry = _context.FixedCostsCategories.Where(x => x.User.Id == userId).ToList();
            foreach (var item in fixedCostCateogry)
            {
                returnList.Add(new FixedCostCategoryDTO
                {
                    Name = item.Name,
                    Cost = item.Cost
                });
            }
            return returnList;
        }

        public async Task Post(FixedCostsCategories fixedCostsCategories, string userId)
        {
            var person = _context.Users.Where(u => u.Id == userId).FirstOrDefault();
            fixedCostsCategories.User = person;
            _context.FixedCostsCategories.Add(fixedCostsCategories);
            await _context.SaveChangesAsync();
        }
    }
}
