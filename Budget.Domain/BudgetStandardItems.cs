using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget.Domain
{
    public class BudgetStandardItems
    {
        public int StandardItemId { get; set; }
        public string Name { get; set; }
        public virtual ItemType Type { get; set; }

        // May need to add list of affected items.
    }
}
