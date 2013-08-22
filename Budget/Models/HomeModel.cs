using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Budget.Models
{
    public class HomeModel
    {


        public IList<BudgetItemModel> IncomeItems { get; set; }
        public IList<BudgetItemModel> ExpenseItems { get; set; }

        public HomeModel()
        {
            IncomeItems = new List<BudgetItemModel>();
            ExpenseItems = new List<BudgetItemModel>();

        }
    }
}