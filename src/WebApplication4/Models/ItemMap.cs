using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace WebApplication4.Models
{
    public class ItemMap : ClassMap<Item>
    {
        public ItemMap()
        {
            Id(item => item.Id).GeneratedBy.Increment();
            Map(item => item.Name);
            Table("items");
        }
    }
}
