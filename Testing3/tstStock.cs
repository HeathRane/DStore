using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            // instantiate class to create
            clsStock AProduct = new clsStock();
            // test to see if it exists
            Assert.IsNotNull(AProduct);
        }

        [TestMethod]
        public void ProductIdPropertyOK()
        {
            // ditto
            clsStock AProduct = new clsStock();
            // create test data to test the property
            int TestData = 0;
            AProduct.ProductId = TestData;
            Assert.AreEqual(AProduct.ProductId, TestData);
        }

        [TestMethod]
        public void ProductNamePropertyOK()
        {
            clsStock AProduct = new clsStock();
            string TestData = "Call of Duty: Modern Warfare 2";
            AProduct.ProductName = TestData;
            Assert.AreEqual(AProduct.ProductName, TestData);
        }

        [TestMethod]
        public void ProductDescriptionPropertyOK()
        {
            clsStock AProduct = new clsStock();
            string TestData = "The most-anticipated game of the year and the sequel to the" +
                " best-selling first-person action game of all time, Modern Warfare 2 continues" +
                " the gripping and heart-racing action as players face off against a new threat" +
                " dedicated to bringing the world to the brink of collapse.";
            AProduct.ProductDescription = TestData;
            Assert.AreEqual(AProduct.ProductDescription, TestData);
        }

        [TestMethod]
        public void ReleaseDatePropertyOK()
        {
            clsStock AProduct = new clsStock();
            DateTime TestData = new DateTime(2009, 11, 12);
            AProduct.ReleaseDate = TestData;
            Assert.AreEqual(AProduct.ReleaseDate, TestData);
        }

        [TestMethod]
        public void PricePropertyOK()
        {
            clsStock AProduct = new clsStock();
            decimal TestData = 19.99M;
            AProduct.Price = TestData;
            Assert.AreEqual(AProduct.Price, TestData);
        }

        [TestMethod]
        public void InStockPropertyOK()
        {
            clsStock AProduct = new clsStock();
            Boolean TestData = true;
            AProduct.InStock = TestData;
            Assert.AreEqual(AProduct.InStock, TestData);
        }
    }
}
