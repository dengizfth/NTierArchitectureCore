using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NTAC.Northwind.DataAccess.Concrete.EntityFramework;


namespace NTAC.DataAccess.TestsDDDD.EntityFrameworkTests
{
    [TestClass]
    public class EntityFrameworkTest
    {
        [TestMethod]
        public void Get_all_returns_all_products()
        {
            EfProductDal productDal = new EfProductDal();

            var result = productDal.GetAll();

            Assert.Arequal
        }
    }
}
