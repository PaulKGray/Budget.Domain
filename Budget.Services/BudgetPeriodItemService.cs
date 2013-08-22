using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Budget.Services.Interfaces;
using Budget.Repository.Interfaces;
using Budget.Domain;

namespace Budget.Services
{
    class BudgetPeriodItemService : IBudgetPeriodItemService
    {
        private IRepository<BudgetPeriodItem> _PeriodItemRepository;

        public BudgetPeriodItemService(IRepository<BudgetPeriodItem> budgetPeriod, IBudgetService budgetService)
        {
            _PeriodItemRepository = budgetPeriod;
       
        }
        
        public BudgetPeriodItem SavePeriodItem(BudgetPeriodItem item)
        {

            if (item.BudgetPeriodItemID == 0)
            {
                item = _PeriodItemRepository.Add(item);
            }
            else
            {
                _PeriodItemRepository.Update(item);
            }

            return item;

        }
                
        public void DeletePeriodItem(BudgetPeriodItem item)
        {
            
            _PeriodItemRepository.Delete(item);
        
        }
    }
}
