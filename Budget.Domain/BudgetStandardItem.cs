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
        public virtual string Description { get; set; }

        protected BudgetStandardItem()
        {

        }

        public BudgetStandardItem(string name, ItemType type, string description)
        {
            this.Name = name;
            this.Type = type;
            this.Description = description;
        }


        public BudgetStandardItem(int id, string name, ItemType type, string description)
        {
            this.StandardItemId = id;
            this.Name = name;
            this.Type = type;
            this.Description = description;
        }

        // May need to add list of affected items.
    }
}
