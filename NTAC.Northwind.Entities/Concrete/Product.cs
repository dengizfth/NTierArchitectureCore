using NTAC.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTAC.Northwind.Entities.Concrete
{
    public class Product :IEntity
    {
        // Devart : Var olan db'deki kolonları buraya otomatik doldurur. 10 Taneye kadar ücretsiz.

        // Fiziksel Northwind Db'deki > Products Tablosundaki> Bir kaç tane KOlon adı girilecek :

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; } 
        public string QuantityPerUnit { get; set; }
        public float UnitPrice { get; set; }
    }
}
