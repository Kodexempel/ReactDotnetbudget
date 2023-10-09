using JohannasReactProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JohannasReactProject.Repositories.Abstract
{
    interface IBalanceRepo
    {
        void Post(Balance balance);
        void Edit(Balance balance);
    }
}
