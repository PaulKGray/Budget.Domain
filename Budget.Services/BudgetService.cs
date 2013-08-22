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
        private IBudgetPeriodService _BudgetPeriodService;


        public BudgetService(IRepository<ClientBudget> repository, 
            IBudgetPeriodService budgetPeriodService)
        {
            _ClientBudgetRepository = repository;
            _BudgetPeriodService = budgetPeriodService;
        }

        /// <summary>
        /// Initial create budget;
        /// </summary>
        /// <returns>A budget</returns>
        public ClientBudget CreateBudget(string username)
        {
            var budget = new ClientBudget(username);

            _ClientBudgetRepository.Add(budget);

            return budget;
        }

        /// <summary>
        /// Used to create a budget when we have a number of items set up
        /// The number is not defined yet and its currently based on months
        /// this could be made customisable but would involve deleting things if reduced v.2.0.
        /// </summary>
        /// <param name="budget">the budget being used</param>
        /// <returns>a budget with periods</returns>
        public ClientBudget SetUpInitialClientBudget(ClientBudget budget) {

            if (budget.Items.Count > 1)
            {
                for (int i = 0; i < 11; i++)
                {
                  budget.AddPeriod(_BudgetPeriodService.CreateNewBudgetPeriod(budget));
                }

            }
            else {
            
                // not sure what to return if we have no budget
            }

            return budget;
        
        }

        public ClientBudget GetBudget(int budgetId, string username)
        {
            var budget = _ClientBudgetRepository.FindBy(budgetId);

            return budget;
        }


        /// <summary>
        /// Recalculates full budget
        /// </summary>
        /// <param name="budget"></param>
        /// <returns></returns>
        public ClientBudget RecalculatedBudget(ClientBudget budget)
        {

            IList<BudgetPeriod> periodsToCalculate = new List<BudgetPeriod>();

        

            foreach (var item in periodsToCalculate)
            {
                
            }

            return budget;
        }
    }
}
