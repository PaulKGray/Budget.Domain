using Budget.Models;
using Budget.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Budget.Controllers
{
    public class HomeController : Controller
    {

        private IStandardItemService _StandardItemService;

        public HomeController(IStandardItemService standardItemService)
        {
            _StandardItemService = standardItemService;
        }
            

        public ActionResult Index()
        {

            var model = new HomeModel();

            var standarditems = _StandardItemService.GetAllStandardITems();

            foreach (var item in standarditems)
            {
                var modelitem = new StandardItem();
                modelitem.Name = item.Name;
                modelitem.Type = item.Type;
                modelitem.Description = item.Description;
                modelitem.id = item.StandardItemId;

                var budgetItemModel = new BudgetItemModel(modelitem);

                budgetItemModel.Name = item.Name;

                if (item.Type == Domain.ItemType.Expense)
                {
                    model.ExpenseItems.Add(budgetItemModel);
                }
                else
                {
                    model.IncomeItems.Add(budgetItemModel);
                }
            }


            return View(model);
        }


    }
}
