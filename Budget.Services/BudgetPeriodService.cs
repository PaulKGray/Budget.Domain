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
    public class BudgetPeriodService : IBudgetPeriodService
    {

        private IRepository<BudgetPeriod> _BudgetPeriodRepository;
        private IBudgetPeriodItemService _BudgetPeriodItemService;

        public BudgetPeriodService(IRepository<BudgetPeriod> budgetPeriod, 
            IBudgetService budgetService, IBudgetPeriodItemService budgetPeriodItemService)
        {
            _BudgetPeriodRepository = budgetPeriod;
            _BudgetPeriodItemService = budgetPeriodItemService;
        }

        public BudgetPeriod CreateNewBudgetPeriod(ClientBudget budget)
        {

            var budgetPeriod = new BudgetPeriod(budget);

            foreach (var item in budget.Items.Where(x=>x.Active ==true))
            {
                var perioditem = new BudgetPeriodItem(budgetPeriod, item);
                _BudgetPeriodItemService.SaveBudgetPeriodItem(perioditem);
                
            }

            budgetPeriod.PeriodCaputureDate = GetNextPeriodDate(budget.Periods);
            
            _BudgetPeriodRepository.Add(budgetPeriod);

            RecalculateBudgetPeriod(budgetPeriod, GetRunningTotal(budget.Periods));
          
            return budgetPeriod;

        }

        public BudgetPeriod RecalculateBudgetPeriod(BudgetPeriod period, decimal runningtotal) {

            period.Expenditure = period.items.Where(x => x.Item.Type == ItemType.Expense).Sum(x => x.Value);
            period.Income = period.items.Where(x => x.Item.Type == ItemType.Income).Sum(x => x.Value);
            period.Bank = (runningtotal + period.Income) - period.Expenditure;

            //ToDo: slightly messy here when adding a new there will be an insert and update (for now so what)
            _BudgetPeriodRepository.Update(period);

            return period;
        }

        private DateTime GetNextPeriodDate(IList<BudgetPeriod> periods) {

            var nextperiodDate = DateTime.Now.AddMonths(1);

            if (periods.Count > 0)
            {
                nextperiodDate = periods.Max(x => x.PeriodCaputureDate).AddMonths(1);

            }
       
            return nextperiodDate;

        }

        public decimal GetRunningTotal(IList<BudgetPeriod> periods) {
        

            var total = periods.Where(x=>x.PeriodCaputureDate == periods.Max(y=>y.PeriodCaputureDate )).Sum(x=>x.Bank);

            return total;

        }


    }
}
