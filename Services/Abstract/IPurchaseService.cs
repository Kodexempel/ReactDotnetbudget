using JohannasReactProject.Models;
using JohannasReactProject.Models.Entities;
using JohannasReactProject.Models.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JohannasReactProject.Services.Abstract
{
     public interface IPurchaseService
    {
        Task Post(Purchase purchase, string userId);
        Task Edit(EditPurchaseDTO editPurchase);
        ICollection<PurchaseDTO> Get(string userId);
    }
}
