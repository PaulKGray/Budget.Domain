using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Budget.Domain;

namespace Budget.Services.Interfaces
{
    public interface IBudgetPeriodService
    {
        BudgetPeriod CreateNewBudgetPeriod(ClientBudget budget);
        BudgetPeriod RecalculateBudgetPeriod(BudgetPeriod period, decimal runningtotal);
        decimal GetRunningTotal(IList<BudgetPeriod> periods);
        

    }
}
