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

        public BudgetItemService(IRepository<BudgetItem> repository)
        {
            _BudgetItemRepository = repository;
        }


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

        public void SaveBudgetItems(IList<BudgetItem> budgetItems) {

            IList<BudgetItem> itemsToAdd = new List<BudgetItem>();

            foreach (var item in budgetItems)
            {
                if (item.BudgetItemid == 0)
                {
                    itemsToAdd.Add(item);
                }
                else {
                    _BudgetItemRepository.Update(item);
                }

            }

            if (itemsToAdd.Count > 0) {
                _BudgetItemRepository.Add(itemsToAdd);
            }
        }
    }
}
