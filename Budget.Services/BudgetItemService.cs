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
    class BudgetItemService : IBudgetItemService    
    
    {
        private IRepository<BudgetItem> _BudgetItemRepository;
        private IBudgetService _BudgetService;


        public BudgetItem  GetBudgetItem(int budgetItemId)
        {
            return _BudgetItemRepository.FindBy(budgetItemId);
        }

        public IList<BudgetItem> GetAllItems(int budgetId)
        {

            ClientBudget budget = _BudgetService.GetBudget(budgetId,"ToDo:AddSecurity");
            return budget.Items;

        }


        public BudgetItem SaveBudgetItem(BudgetItem budgetItem)
        {
            if (budgetItem.BudgetItemid == 0) {
                budgetItem = _BudgetItemRepository.Add(budgetItem);
            } else {
                _BudgetItemRepository.Update(budgetItem);
            }

            return budgetItem;

        }


        
    }
}
