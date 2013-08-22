using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Budget.Models
{
    public class BudgetItemModel
    {
        StandardItem standardItem;

        [DisplayName("Item Type")]
        public string Name { get; set; }


        public BudgetItemModel(StandardItem item)
        {
            this.standardItem = item;
        }
    }
}