using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget.Domain
{
    public class BudgetItem
    {
        public virtual int BudgetItemid { get; set; }
        public virtual ClientBudget Budget { get; set; }
        public virtual string Name { get; set; }
        public virtual BudgetStandardItem StandardItem { get; set; }
        public virtual ItemType Type { get; set; }
        public virtual bool Active { get; set; }
        public virtual decimal DefaultValue { get; set; }

        protected BudgetItem(){
        
        }

        public BudgetItem(ClientBudget budget, ItemType type)
        {
            this.Budget = budget;
            this.Type = type;
            DefaultValue = 0;
        }
        
        public virtual void AddStandardType(BudgetStandardItem standardItem) {
             this.StandardItem = standardItem;
            this.Type = standardItem.Type;
            this.Name = standardItem.Name;
        }

      

    }
}
