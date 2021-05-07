using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        int productId = 9;
        string productName = "Metal Gear Solid";
        DateTime releaseDate = Convert.ToDateTime("03/09/1998");
        decimal price = Convert.ToDecimal(7.19);
        bool inStock = true;
        string productDesc = "You are Snake, a government agent on a mission to regain control of a secret nuclear weapons base from terrorist hands.";

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
            int TestData = 1;
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

        [TestMethod]
        public void FindMethodOK()
        {
            clsStock AProduct = new clsStock();
            Boolean Found = false;
            int ProductId = 1;
            Found = AProduct.Find(ProductId);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestProductIdFound()
        {
            clsStock AProduct = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            int ProductId = 11;
            Found = AProduct.Find(ProductId);
            if (AProduct.ProductId != 11)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductNameFound()
        {
            clsStock AProduct = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            int ProductId = 11;
            Found = AProduct.Find(ProductId);
            if (AProduct.ProductName != "Game 1")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestReleaseDateFound()
        {
            clsStock AProduct = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            int ProductId = 11;
            Found = AProduct.Find(ProductId);
            if (AProduct.ReleaseDate != Convert.ToDateTime("01/01/2001"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            clsStock AProduct = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            int ProductId = 11;
            Found = AProduct.Find(ProductId);
            if (AProduct.Price != Convert.ToDecimal(10.00))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestInStockFound()
        {
            clsStock AProduct = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            int ProductId = 11;
            Found = AProduct.Find(ProductId);
            if (AProduct.InStock != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductDescriptionFound()
        {
            clsStock AProduct = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            int ProductId = 11;
            Found = AProduct.Find(ProductId);
            if (AProduct.ProductDescription != "A game.")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsStock AProduct = new clsStock();
            string Error = "";
            Error = AProduct.Valid(productId, productName, releaseDate, price, inStock, productDesc);
            Assert.AreEqual(Error, "");
        }
    }
}
