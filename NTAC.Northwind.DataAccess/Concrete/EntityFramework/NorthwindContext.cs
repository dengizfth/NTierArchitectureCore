using NTAC.Northwind.DataAccess.Concrete.EntityFramework.Mappings;
using NTAC.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace NTAC.Northwind.DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext :DbContext
    {
       
        public NorthwindContext()
        { // Hazır Bir Veri Tabanım olduğu için Gidip yeni bir Veritabanı Oluşturmaması İçin ...
            Database.SetInitializer<NorthwindContext>(null);
        }

        
        public DbSet<Product> Products { get; set; }
        // Ve Diper Tablolar ...


        // Mapping İşlemini Ayağa Kaldırmak için :
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductMap());
            // Ve Diper Mapping işlmeri Buraya Eklenir ...
        }

    }
}
