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
    public class BudgetService : IBudgetService
    {
        
        private IRepository<ClientBudget> _ClientBudgetRepository;
        private IBudgetPeriodService _PeriodService;
        private IBudgetPeriodItemService _PeriodItemService;


        public BudgetService(IRepository<ClientBudget> repository, 
            IBudgetPeriodService periodService, IBudgetPeriodItemService peridItemService)
        {
            _ClientBudgetRepository = repository;
            _PeriodService = periodService;
            _PeriodItemService = peridItemService;

        }

        public ClientBudget CreateBudget()
        {
            var budget = new ClientBudget();

            _ClientBudgetRepository.Add(budget);

            return budget;
        }

        public ClientBudget GetBudget(int budgetId, string username)
        {
            var budget = _ClientBudgetRepository.FindBy(budgetId);

            return budget;
        }

        public ClientBudget RecalculatedBudget(Domain.ClientBudget budget)
        {

            var balance = budget.StartingBalance;

            foreach (var period in budget.Periods.OrderBy(x => x.PeriodCaputureDate))
            {

               


                foreach (var item in period.Items.OrderBy(x=>x.Item))
                {
                    //ToDo: some sort of check touched type thing
                    _PeriodItemService.SavePeriodItem(item);
                }

                balance = _PeriodService.CalculatePeriod(period, balance);       
                
            }

            throw new NotImplementedException();
        }
    }
}
