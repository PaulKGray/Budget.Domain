using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Budget.Domain;
using FluentNHibernate.Mapping;

namespace Budget.Repository.Mappings
{
    class BudgetPeriodItemMap : ClassMap<BudgetPeriodItem>
    {
        public BudgetPeriodItemMap()
        {
            Table("BudgetPeriodItem");
            Id(x => x.BudgetPeriodItemID);
            Map(x => x.Value);
            HasOne(x => x.BudgetPeriod);
            HasOne(x => x.Item);
        }
    }
}
