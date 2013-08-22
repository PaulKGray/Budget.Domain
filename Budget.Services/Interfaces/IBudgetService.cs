using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Budget.Domain;

namespace Budget.Services.Interfaces
{
    public interface IBudgetService
    {
        public ClientBudget CreateBudget();
        public ClientBudget GetBudget(int budgetId, string username);
        public ClientBudget RecalculatedBudget(ClientBudget budget);

    }
}
