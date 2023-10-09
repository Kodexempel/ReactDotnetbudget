using JohannasReactProject.Data;
using JohannasReactProject.Models;
using JohannasReactProject.Models.Entities;
using JohannasReactProject.Models.Web;
using JohannasReactProject.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JohannasReactProject.Repositories.Concrete
{
    public class PurchaseRepo  : IPurchaseRepo
    {
        private readonly ApplicationDbContext _context;
        public PurchaseRepo(ApplicationDbContext context) => _context = context;
        public async Task Edit(EditPurchaseDTO editPurchaseDTO)
        {
            var foundPurchase = _context.Purchases.Where(x => x.Id == editPurchaseDTO.Id).FirstOrDefault();

            foundPurchase.Name = editPurchaseDTO.Name;

            foundPurchase.Price = editPurchaseDTO.Price;

            foundPurchase.Date = editPurchaseDTO.Date;



            await _context.SaveChangesAsync();
        }

        public ICollection<PurchaseDTO> Get(string userId)
        {
            var returnList = new List<PurchaseDTO>();
            var purchases = _context.Purchases.Where(x => x.User.Id == userId).ToList();
            
            foreach(var item in purchases)
            {
                returnList.Add(new PurchaseDTO
                {
                    Price = item.Price,
                    Date = item.Date,
                    Name = item.Name
                });
            }

            return returnList;
        }

        public async Task Post(Purchase purchases, string userId)
        {
          
            var category = purchases.VariableCostsCategory.Id;
            var person = _context.Users.Where(u => u.Id == userId).FirstOrDefault();
            var variableCategory = _context.VariableCostsCategories.Where(x => x.Id == category).FirstOrDefault();
            purchases.VariableCostsCategory = variableCategory;
            purchases.User = person;
            _context.Purchases.Add(purchases);
            await _context.SaveChangesAsync();
        }
    }
}
