using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Budget.Domain;


namespace Budget.Services.Interfaces
{
    public interface IStandardItemService
    {
        BudgetStandardItem GetStandardItem(int id);
        IList<BudgetStandardItem> GetAllStandardITems();
        BudgetStandardItem AddNewStandardItem(BudgetStandardItem NewStandardItem);
        bool DeleteStandardItem(BudgetStandardItem StandardItem);
        bool DeleteStandardItem(int id);
        bool EditStandardItem(BudgetStandardItem standardItem);

    }
}
