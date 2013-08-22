using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget.Domain
{
    public class BudgetPeriod
    {
        public virtual int BudgetPeriodId { get; set; }
        public virtual ClientBudget Budget { get; set; }
        public virtual decimal Income { get; set; }
        public virtual decimal Bank { get; set; }
        public virtual decimal Expenditure { get; set; }
        public virtual DateTime PeriodCaputureDate { get; set; }
        public virtual IList<BudgetPeriodItem> items { get; set; }
        public virtual bool Locked { get; set; }


        protected BudgetPeriod()
        {

        }

        public BudgetPeriod(ClientBudget budget)
        {
            this.items = new List<BudgetPeriodItem>();
            this.Budget = budget;
            this.Locked = false;
        }

        public virtual BudgetPeriodItem AddItem (BudgetPeriodItem item){

            item.BudgetPeriod = this;
            this.items.Add (item);

            return item;
        }


      
    }


}
