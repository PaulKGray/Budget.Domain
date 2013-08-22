using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Budget.Domain;
using FluentNHibernate.Mapping;

namespace Budget.Repository.Mappings
{
    class BudgetStandardItemMap : ClassMap<BudgetStandardItems>
    {
        public BudgetStandardItemMap()
        {
            Table("StandardItem");
            Id(x => x.StandardItemId);
            Map(x => x.Name);
            Map(x=> x.Type);



        }
    }
}
