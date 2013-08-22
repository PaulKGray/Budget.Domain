using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Budget.Domain;

namespace Budget.Services.Interfaces
{
    interface IBudgetPeriodItemService
    {
        public BudgetPeriodItem SavePeriodItem(BudgetPeriodItem item);

        public void DeletePeriodItem(BudgetPeriodItem item);

    }


}
