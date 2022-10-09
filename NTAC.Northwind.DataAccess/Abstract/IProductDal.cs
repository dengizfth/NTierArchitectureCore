using NTAC.Core.DataAccess;
using NTAC.Northwind.Entities.ComplexTypes;
using NTAC.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTAC.Northwind.DataAccess.Abstract
{
    public interface IProductDal :IEntityRepository<Product>
    {
        List<ProductDetail> GetProductDetails();
    }
}
