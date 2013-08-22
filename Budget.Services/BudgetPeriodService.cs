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
    class BudgetPeriodService : IBudgetPeriodService
    {

        private IRepository<BudgetPeriod> _BudgetPeriod;
        private IBudgetService _BudgetService;

        public BudgetPeriodService(IRepository<BudgetPeriod> budgetPeriod, IBudgetService budgetService)
        {
            _BudgetPeriod = budgetPeriod;
            _BudgetService = budgetService;
        }

        public BudgetPeriod CreateNewBudgetPeriod(int budgetId)
        {
            var budget = new ClientBudget();
            budget = _BudgetService.GetBudget(budgetId, "test");

            var budgetPeriod = new BudgetPeriod(budget);

            budgetPeriod.PeriodCaputureDate = GetNextPeriodDate(budget.Periods);
          
            return budgetPeriod;

        }

        private DateTime GetNextPeriodDate(IList<BudgetPeriod> periods) {

            var nextperiodDate = DateTime.Now.AddMonths(1);

            if (periods.Count > 0)
            {
                nextperiodDate = periods.Max(x => x.PeriodCaputureDate).AddMonths(1);

            }
       
            return nextperiodDate;

        
        }

        public BudgetPeriod CalculatePeriod(BudgetPeriod period, decimal previousbalance) {

            var diffrence = period.Income - period.Expenditure;
            period.Balance = previousbalance + diffrence;

            _BudgetPeriod.Update(period);

            return period;
        }

    }
}
