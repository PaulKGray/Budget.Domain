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
        /// <summary>
        /// Constuctor for budget items off standard item types.
        /// adds the name and type off the standard item all
        /// we need to worry about is the value
        /// </summary>
        /// <param name="standardItem"></param>
        public BudgetItem(ClientBudget budget, BudgetStandardItem standardItem, decimal defaultvalue, string name, ItemType type)
        {
            this.Budget = budget;
            this.StandardItem = standardItem;
            this.Type = type;
            this.Name = name;
            this.DefaultValue = defaultvalue;
            this.Active = true;
        }

      

    }
}
