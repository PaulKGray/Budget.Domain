using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget.Domain
{
    public class BudgetPeriodItem
    {

        public int BudgetPeriodItemID {get;set;}
        public BudgetPeriod BudgetPeriod { get; set; }
        public BudgetItem Item { get; set; }

        public decimal Value { get; set; }

        public BudgetPeriodItem(BudgetPeriod budgetPeriod, BudgetItem item)
        {
            this.BudgetPeriod = budgetPeriod;
            this.Item = item;
            this.Value = item.DefaultValue;
        }



    }
}
