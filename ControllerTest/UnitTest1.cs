using DRRecordREST.Controllers;
using DRRecordREST.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;


namespace ControllerTest
{
    [TestClass]
    public class UnitTest1
    {
        //private static readonly List<Record> records = new List<Record>()
        //{
        //    new Record("First Night Back in Town", "Ye Banished Privateers", 1.07, 2017),
        //    new Record("Meteora", "Linkin Park", 3.44, 2011)
        //};
        [TestMethod]
        public void TestGetAll()
        {

            var controller = new RecordsController();

            var result = controller.GetRecords() as List<Record>;

            Assert.AreEqual(2, result.Count);
        }

        [TestMethod]
        public void TestGetRecordByTitle()
        {

            var controller = new RecordsController();

            var result = controller.GetByTitle("Castle of Glass");

            Assert.AreEqual("Castle of Glass", result.Title);
            Assert.AreEqual("Linkin Park", result.Artist);
        }

    }
}
