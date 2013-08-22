using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget.Domain
{
    public class ClientBudget
    {
        public virtual int BudgetId { get; set; }
        public virtual DateTime Created { get; set; }
        public virtual IList<BudgetItem> Items { get; set; }
        public virtual IList<BudgetPeriod> Periods { get; set; }
        public virtual string Username { get; set; }
        public virtual decimal StartingBalance { get; set; }

        public ClientBudget()
        {
            Items = new List<BudgetItem>();
            Periods = new List<BudgetPeriod>();
        }

        public virtual void AddItem(BudgetItem item){
            item.Budget = this;
            Items.Add(item);   
        }

        public virtual void AddPeriod(BudgetPeriod period) { 
        
          
        }



        
    }
}
