using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mvc_MongoDB.Models;
using Mvc_MongoDB.Controllers;
using Mvc_MongoDB.Repository;

namespace test.create
{
    [TestClass]
    public class UnitTest1
    {
      
        [TestMethod]
        public void TestMethod1()
        {
            ItemDB itemdb = new ItemDB();
            Item item = new Item();

            item.NomeItem = "xablau";
            item.CategoriaItem = "gta";
            item.QuantidadeItem = 5.0;

            itemdb.Create(item);
        }
    }
}
