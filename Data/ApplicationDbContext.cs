using IdentityServer4.EntityFramework.Options;
using JohannasReactProject.Models;
using JohannasReactProject.Models.Entities;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JohannasReactProject.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Budget> Budgets { get; set; }

        public DbSet<VariableCostsCategories> VariableCostsCategories { get; set; }

        public DbSet<FixedCostsCategories> FixedCostsCategories { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<SavingGoal> SavingGoals { get; set; }
        public DbSet<BudgetCategory> BudgetCategories { get; set; }
    }
}
