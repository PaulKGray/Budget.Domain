using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Budget.Controllers.Actionfilters;
using Budget.Models;
using Budget.Services.Interfaces;

namespace Budget.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/

        private IStandardItemService _StandardItemService;

        public AdminController(IStandardItemService standardItemService)
        {
            _StandardItemService = standardItemService;
        }
            
        public ActionResult Index()
        {

            AdminModel adminModel = PopulateAdminModel();

            return View(adminModel);
        }

        private AdminModel PopulateAdminModel()
        {
            var adminModel = new AdminModel();

            adminModel.StandardItems = _StandardItemService.GetAllStandardITems();


            return adminModel;

        }

        [HttpGet]
        public ActionResult CreateNew()
        {
            var StandardItem = new Budget.Models.StandardItem();
            return View(StandardItem);
        }

        [HttpPost]
        public ActionResult CreateNew(StandardItem item) {

            if (ModelState.IsValid) {

            // needs to assign correct enum for expense type.
            var theNewStandardItem = new Budget.Domain.BudgetStandardItem(item.Name, item.Type, item.Description);
            _StandardItemService.AddNewStandardItem(theNewStandardItem);

            return RedirectToAction("Index");

            }

            return View(item);
        }

        [HttpGet]
        public ActionResult EditStandardItem(int id)
        {
            var theStandardItem = _StandardItemService.GetStandardItem(id);
            var theModelStandardItem = new StandardItem();
           
            theModelStandardItem.Name = theStandardItem.Name;
            theModelStandardItem.id = theStandardItem.StandardItemId;
            theModelStandardItem.Description = theStandardItem.Description;
            // to deal with
            theModelStandardItem.Type = Domain.ItemType.Expense;
            return View(theModelStandardItem);
        }

        [Transaction]
        [HttpPost]
        public ActionResult EditStandardItem(StandardItem item)
        {
            if (ModelState.IsValid)
            {

                var DomStandardItem = new Budget.Domain.BudgetStandardItem(item.Name, item.Type, item.Description);
                DomStandardItem.StandardItemId = item.id;

                _StandardItemService.EditStandardItem(DomStandardItem);

                return RedirectToAction("Index");
            }

            return View(item);
        }

        [Transaction]
        [HttpGet]
        public ActionResult DeleteStandardItem(int id) {

            _StandardItemService.DeleteStandardItem(id);

            return RedirectToAction("Index");
        }

    }
}
