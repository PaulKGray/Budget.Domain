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
        public virtual IList<BudgetItem> BudgetItems { get; set; }

        protected BudgetStandardItem()
        {
            this.BudgetItems = new List<BudgetItem>();
        }

        public BudgetStandardItem(int id)
        {
            this.BudgetItems = new List<BudgetItem>();
            this.StandardItemId = id;
        }

        public BudgetStandardItem(string name, ItemType type, string description)
        {
            this.BudgetItems = new List<BudgetItem>();
            this.Name = name;
            this.Type = type;
            this.Description = description;
        }


        public BudgetStandardItem(int id, string name, ItemType type, string description)
        {
            this.BudgetItems = new List<BudgetItem>();
            this.StandardItemId = id;
            this.Name = name;
            this.Type = type;
            this.Description = description;
        }

        // May need to add list of affected items.
    }
}
