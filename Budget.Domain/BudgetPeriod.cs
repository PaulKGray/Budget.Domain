using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget.Domain
{
    public class BudgetPeriod
    {
        public int BudgetPeriodId { get; set; }
        public virtual ClientBudget Budget { get; set; }
        public decimal Income { get; set; }
        public decimal Expenditure { get; set; }
        public decimal Balance { get; set; }
        public DateTime PeriodCaputureDate { get; set; }
        public IList<BudgetPeriodItem> Items { get; set; }

        public BudgetPeriod(ClientBudget budget)
        {
            Items = new List<BudgetPeriodItem>();
            this.Budget = budget;
        }

        public virtual void AddItem(BudgetPeriodItem item)
        {
            item.BudgetPeriod = this;
            Items.Add(item);
        }


      
    }


}
