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
        public BudgetPeriod CreateNewBudgetPeriod(int budgetId);

        public decimal CalculatePeriod(BudgetPeriod period, decimal previousbalance);
        

    }
}
