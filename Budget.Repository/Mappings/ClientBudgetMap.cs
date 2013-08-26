using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Budget.Domain;
using FluentNHibernate.Mapping;

namespace Budget.Repository.Mappings
{
    public class ClientBudgetMap : ClassMap<ClientBudget>
    {
        public ClientBudgetMap()
        {
            Table("ClientBudget");
            Id(x => x.BudgetId);
            Map(x => x.Created);
            HasMany(x => x.Items).Cascade.All();
            HasMany(x => x.Periods);
        }
   
    }
}
