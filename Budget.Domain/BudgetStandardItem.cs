using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget.Domain
{
    public class BudgetStandardItem
    {
        public virtual  int StandardItemId { get; set; }
        public virtual string Name { get; set; }
        public virtual ItemType Type { get; set; }

        protected BudgetStandardItem()
        {

        }

        public BudgetStandardItem(string name, ItemType type)
        {
            this.Name = name;
            this.Type = type;
        }

        // May need to add list of affected items.
    }
}
