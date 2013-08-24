using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Budget.Domain;

namespace Budget.Services.Interfaces
{
    public interface IBudgetItemService
    {
        BudgetItem GetBudgetItem(int budgetItemId);
        void SaveBudgetItem(BudgetItem budgetItem);
        void SaveBudgetItems(IList<BudgetItem> budgetItems);

    }
}
