using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Budget.Models
{
    public class ItemTypeList
    {
        public int Id { get; set; }
        public Budget.Domain.ItemType Type { get; set; }

        public ItemTypeList(int id, string typeName, Budget.Domain.ItemType type)
        {
            this.Id = id;
            this.Type = type;
        }

        public static IEnumerable<ItemTypeList> ItemTypes = new List<ItemTypeList>
        {
            new ItemTypeList(1,"Expense", Domain.ItemType.Expense),
            new ItemTypeList(2,"Income", Domain.ItemType.Income)

        };

    }
}