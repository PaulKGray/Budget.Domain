using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Budget.Services.Interfaces;
using Budget.Domain;
using Budget.Repository.Interfaces;
using Budget.Repository;
using NHibernate;

namespace Budget.Services
{
    public class StandardItemService : IStandardItemService 
    {

        private IRepository<BudgetStandardItem> _StandardItemRepository;

        public StandardItemService(IRepository<BudgetStandardItem> repository)
        {
            _StandardItemRepository = repository;
        }

        public BudgetStandardItem GetStandardItem(int id)
        {
            var standardItem = _StandardItemRepository.FindBy(id);
            return standardItem;
        }

        public IList<BudgetStandardItem> GetAllStandardITems()
        {
            var standardItems = _StandardItemRepository.FindAll();
            return standardItems;
        }

        public BudgetStandardItem AddNewStandardItem(BudgetStandardItem NewStandardItem)
        {
            var standardItem = _StandardItemRepository.Add(NewStandardItem);
            return standardItem;
        }

        public bool DeleteStandardItem(BudgetStandardItem StandardItem)
        {
            bool result = _StandardItemRepository.Delete(StandardItem);
            return result;
        }

        public bool DeleteStandardItem(int id)
        {
            var itemToDelete = GetStandardItem(id);
            bool result = _StandardItemRepository.Delete(itemToDelete);
            return result;
        }
  
        public bool EditStandardItem(BudgetStandardItem standardItem)
        {
            var result = _StandardItemRepository.Update(standardItem);
            return result;
        }
    }

}
