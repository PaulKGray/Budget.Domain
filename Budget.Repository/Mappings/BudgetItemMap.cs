using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Budget.Domain;
using FluentNHibernate.Mapping;

namespace Budget.Repository.Mappings
{
    class BudgetItemMap : ClassMap<BudgetItem>
    {
        public BudgetItemMap()
        {
            Table("BudgetItem");
            Id(x => x.BudgetItemid);
            Map(x => x.DefaultValue);
            Map(x => x.Name);
            Map(x => x.Type);
            HasOne(x => x.StandardItem).Constrained();
            HasOne(x => x.Budget).Cascade.None();
        }
    }
}
