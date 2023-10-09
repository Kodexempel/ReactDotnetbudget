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
    public class PurchaseService : IPurchaseService
    {
        private readonly IPurchaseRepo _purchaseRepo;
        public PurchaseService(IPurchaseRepo purchaseRepo) => _purchaseRepo = purchaseRepo;
        public async Task Edit(EditPurchaseDTO purchase)
        {
            await _purchaseRepo.Edit(purchase);
        }

        public ICollection<PurchaseDTO> Get(string userId)
        {
            return _purchaseRepo.Get(userId);
        }

        public async Task Post(Purchase purchase, string userId)
        {
            await _purchaseRepo.Post(purchase, userId);
        }
    }
}

    