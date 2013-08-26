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
        ClientBudget CreateBudget(string username);
        ClientBudget GetBudget(int budgetId, string username);
        ClientBudget RecalculatedBudget(ClientBudget budget);
        ClientBudget SaveBudget(ClientBudget budget);
    }
}
