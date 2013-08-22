using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Budget.Domain;
using FluentNHibernate.Mapping;

namespace Budget.Repository.Mappings
{
    class BudgetPeriodMap : ClassMap<BudgetPeriod>
    {
        public BudgetPeriodMap()
        {
            Table("BudgetPeriod");
            Id(x => x.BudgetPeriodId);
            Map(x => x.Income);
            Map(x => x.Expenditure);
            Map(x => x.PeriodCaputureDate);
            Map(x => x.Balance);
            HasOne(x => x.Budget);
        }
    }
}
