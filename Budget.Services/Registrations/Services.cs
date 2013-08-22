using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Budget.Services.Interfaces;
using Budget.Repository.Interfaces;
using Budget.Repository;

using Ninject;
using Budget.Domain;


namespace Budget.Services.Registrations
{
    public static class Services
    {
        public static void RegisterServices(IKernel kernel)
        {
            
            // services

            
            kernel.Bind<IBudgetService>().To<BudgetService>();
            kernel.Bind<IBudgetPeriodService>().To<BudgetPeriodService>();
            kernel.Bind<IBudgetItemService>().To<BudgetItemService>();
            kernel.Bind<IBudgetPeriodItemService>().To<BudgetPeriodItemService>();
            kernel.Bind<IStandardItemService>().To<StandardItemService>();

            // repositories

            kernel.Bind(typeof(IRepository<>)).To(typeof(Repository<>));

        }
    }
}
