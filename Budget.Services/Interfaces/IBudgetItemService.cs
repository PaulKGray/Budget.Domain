using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Budget.Domain;

namespace Budget.Services.Interfaces
{
    interface IBudgetItemService
    {
        public BudgetItem GetBudgetItem(int budgetItemId);
        public void SaveBudgetItem(BudgetItem budgetItem);

    }
}
