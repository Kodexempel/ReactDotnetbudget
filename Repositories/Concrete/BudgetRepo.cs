using JohannasReactProject.Data;
using JohannasReactProject.Models;
using JohannasReactProject.Models.Entities;
using JohannasReactProject.Models.Web;
using JohannasReactProject.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JohannasReactProject.Repositories.Concrete
{
    public class BudgetRepo : IBudgetRepo
    {
        private readonly ApplicationDbContext _context;

        public BudgetRepo(ApplicationDbContext context) => _context = context;
        public async Task Edit(EditBudgetDTO budget)
        {
            var foundBudget = _context.Budgets.Where(x => x.Id == budget.Id).FirstOrDefault();
           
                foundBudget.Income = budget.Income;
                foundBudget.StartDate = budget.StartDate;
                foundBudget.EndDate = budget.EndDate;

            await _context.SaveChangesAsync();
            
        }

        public IEnumerable<BudgetDTO> Get(string userId)
        {
            var list = new List<BudgetDTO>();
            var fixedList = new List<FixedCostCategoryDTO>();

            var budget = _context.Budgets.Where(b => b.User.Id == userId).ToList();
            

            foreach (var item in budget)
            {
                //FÖR ATT HÄMTA BUDGET OCH EN LISTA AV FIXEDCOSTCATEGORIES

                //foreach(var fixedCost in item.FixedCostsCategories)
                //{
                //    fixedList.Add(new FixedCostCategoryDTO
                //    {
                //        Name = fixedCost.Name,
                //        Cost = fixedCost.Cost
                //    });
                //}
                list.Add(new BudgetDTO
                {
                    
                    StartDate = item.StartDate,
                    EndDate = item.EndDate,
                    Income = item.Income,
                    Unbudgeted = item.Unbudgeted,
                    //fixedCostCategoryDTO = fixedList
                    
                });
            }
           
            return list;
        }

        public async Task Post(Budget budget, string userId)
        {
            var person = _context.Users.Where(u => u.Id == userId).FirstOrDefault();
            var fixedCosts = _context.FixedCostsCategories.Where(f => f.User.Id == userId).ToList();

            budget.User = person;
            budget.FixedCostsCategories = fixedCosts;
            _context.Budgets.Add(budget);
           await _context.SaveChangesAsync();
        }
    }
}
