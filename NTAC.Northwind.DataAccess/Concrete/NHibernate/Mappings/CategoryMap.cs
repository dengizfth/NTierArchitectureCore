using FluentNHibernate.Conventions.Helpers;
using FluentNHibernate.Mapping;
using NTAC.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTAC.Northwind.DataAccess.Concrete.NHibernate.Mappings
{
    public class CategoryMap : ClassMap<Category>
    {
        public CategoryMap()
        {
            Table(@"Categories");
            LazyLoad();
            Id(x => x.CategoryId).Column("CategoryID");

            //Map(x => x.CategoryId).Column("CategoryId"); // Nhibernate'te Id Verildiği için Burada Id'yi tekrar Map Yapmaya gerek yok.
            Map(x => x.CategoryName).Column("CategoryName");

        }

    }
}
