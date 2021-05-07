using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStockCollection AllProducts = new clsStockCollection();
            Assert.IsNotNull(AllProducts);
        }

        [TestMethod]
        public void StockListOK()
        {
            clsStockCollection AllProducts = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();

            clsStock TestItem = new clsStock();
            TestItem.ProductId = 1;
            TestItem.ProductName = "game 2";
            TestItem.ReleaseDate = DateTime.Now.Date;
            TestItem.Price = Convert.ToDecimal(4.20);
            TestItem.InStock = false;
            TestItem.ProductDescription = "yet another game";

            TestList.Add(TestItem);
            AllProducts.ProductsList = TestList;
            Assert.AreEqual(AllProducts.ProductsList, TestList);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            clsStockCollection AllProducts = new clsStockCollection();
            int SomeCount = 2;
            AllProducts.Count = SomeCount;
            Assert.AreEqual(AllProducts.Count, SomeCount);
        }

        [TestMethod]
        public void ThisStockPropertyOK()
        {
            clsStockCollection AllProducts = new clsStockCollection();
            clsStock TestProduct = new clsStock();

            TestProduct.ProductId = 1;
            TestProduct.ProductName = "game 2";
            TestProduct.ReleaseDate = DateTime.Now.Date;
            TestProduct.Price = Convert.ToDecimal(4.20);
            TestProduct.InStock = false;
            TestProduct.ProductDescription = "yet another game";

            AllProducts.ThisProduct = TestProduct;
            Assert.AreEqual(AllProducts.ThisProduct, TestProduct);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsStockCollection AllProducts = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();

            clsStock TestProduct = new clsStock();
            TestProduct.ProductId = 1;
            TestProduct.ProductName = "game 2";
            TestProduct.ReleaseDate = DateTime.Now.Date;
            TestProduct.Price = Convert.ToDecimal(4.20);
            TestProduct.InStock = false;
            TestProduct.ProductDescription = "yet another game";

            TestList.Add(TestProduct);
            AllProducts.ProductsList = TestList;
            Assert.AreEqual(AllProducts.Count, TestList.Count);
        }


        [TestMethod]
        public void AddMethodOK()
        {
            clsStockCollection AllProducts = new clsStockCollection();
            clsStock TestProduct = new clsStock();
            int PrimaryKey = 0;

            TestProduct.ProductId = 1;
            TestProduct.ProductName = "game 2";
            TestProduct.ReleaseDate = DateTime.Now.Date;
            TestProduct.Price = Convert.ToDecimal(4.20);
            TestProduct.InStock = false;
            TestProduct.ProductDescription = "yet another game";

            AllProducts.ThisProduct = TestProduct;
            PrimaryKey = AllProducts.Add();
            TestProduct.ProductId = PrimaryKey;

            AllProducts.ThisProduct.Find(PrimaryKey);
            Assert.AreEqual(AllProducts.ThisProduct, TestProduct);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsStockCollection AllProducts = new clsStockCollection();
            clsStock TestProduct = new clsStock();
            int PrimaryKey = 0;

            TestProduct.ProductId = 1;
            TestProduct.ProductName = "game 2";
            TestProduct.ReleaseDate = DateTime.Now.Date;
            TestProduct.Price = Convert.ToDecimal(4.20);
            TestProduct.InStock = false;
            TestProduct.ProductDescription = "yet another game";

            AllProducts.ThisProduct = TestProduct;
            PrimaryKey = AllProducts.Add();

            TestProduct.ProductId = PrimaryKey;

            TestProduct.ProductId = 67;
            TestProduct.ProductName = "game 8";
            TestProduct.ReleaseDate = DateTime.Now.Date;
            TestProduct.Price = Convert.ToDecimal(1.20);
            TestProduct.InStock = false;
            TestProduct.ProductDescription = "and ofc yet another game";

            AllProducts.ThisProduct = TestProduct;
            AllProducts.Update();
            AllProducts.ThisProduct.Find(PrimaryKey);
            Assert.AreEqual(AllProducts.ThisProduct, TestProduct);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsStockCollection AllProducts = new clsStockCollection();
            clsStock TestProduct = new clsStock();
            int PrimaryKey = 0;

            TestProduct.ProductId = 1;
            TestProduct.ProductName = "game 2";
            TestProduct.ReleaseDate = DateTime.Now.Date;
            TestProduct.Price = Convert.ToDecimal(4.20);
            TestProduct.InStock = false;
            TestProduct.ProductDescription = "yet another game";

            AllProducts.ThisProduct = TestProduct;
            PrimaryKey = AllProducts.Add();

            TestProduct.ProductId = PrimaryKey;

            AllProducts.ThisProduct.Find(PrimaryKey);
            AllProducts.Delete();

            Boolean Found = AllProducts.ThisProduct.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByPriceMethodOK()
        {
            clsStockCollection AllProducts = new clsStockCollection();
            clsStockCollection FilteredProducts = new clsStockCollection();
            FilteredProducts.ReportByPrice(0);
            Assert.AreEqual(AllProducts.Count, FilteredProducts.Count);
        }

        [TestMethod]
        public void ReportByPriceNoneFound()
        {
            clsStockCollection FilteredProducts = new clsStockCollection();
            FilteredProducts.ReportByPrice(Convert.ToDecimal(1.00));
            Assert.AreEqual(0, FilteredProducts.Count);
        }
    }
}
