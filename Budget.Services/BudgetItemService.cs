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
    public class BudgetItemService : IBudgetItemService    
    
    {
        private IRepository<BudgetItem> _BudgetItemRepository;
        private IBudgetService _BudgetService;


        public BudgetItem  GetBudgetItem(int budgetItemId)
        {
            return _BudgetItemRepository.FindBy(budgetItemId);
        }

        public void SaveBudgetItem(BudgetItem budgetItem)
        {
            if (budgetItem.BudgetItemid == 0) {
               _BudgetItemRepository.Add(budgetItem);
            } else {
                _BudgetItemRepository.Update(budgetItem);
            }

        }
    }
}
