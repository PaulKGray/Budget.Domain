using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget.Domain
{
    public class BudgetPeriodItem
    {

        public virtual int BudgetPeriodItemID {get;set;}
        public virtual BudgetPeriod BudgetPeriod { get; set; }
        public virtual BudgetItem Item { get; set; }
        public virtual ItemType Type { get; set; }

        public virtual decimal Value { get; set; }

        protected BudgetPeriodItem()
        {

        }


        /// <summary>
        /// Constructor for items creates the basic info off the back of items
        /// </summary>
        /// <param name="budgetPeriod"></param>
        /// <param name="item"></param>
        public BudgetPeriodItem(BudgetPeriod budgetPeriod, BudgetItem item)
        {
            this.BudgetPeriod = budgetPeriod;
            this.Item = item;
            this.Value = item.DefaultValue;
            this.Type = item.Type;
        }


    }
}
