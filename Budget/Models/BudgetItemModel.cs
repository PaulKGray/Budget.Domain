using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Budget.Models
{
    public class BudgetItemModel
    {
        public StandardItem standardItem;

        [DisplayName("Item")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [DisplayName("Amount")]
        public decimal DefaultValue { get; set; }

        public BudgetItemModel()
        {

        }

        public BudgetItemModel(StandardItem item)
        {
            this.standardItem = item;
        }
    }
}