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
    public class BudgetPeriodItemService : IBudgetPeriodItemService 
    {

        private IRepository<BudgetPeriodItem> _BudgetPeriodItem;

        public BudgetPeriodItemService(IRepository<BudgetPeriodItem> budgetPeriodItem)
        {
            _BudgetPeriodItem = budgetPeriodItem;
        }


        public BudgetPeriodItem SaveBudgetPeriodItem(BudgetPeriodItem item)
        {
            if (item.BudgetPeriodItemID == 0) {
                item = _BudgetPeriodItem.Add(item);
            } else {
                _BudgetPeriodItem.Update(item);
            }

            return item;
        }
    }
}
