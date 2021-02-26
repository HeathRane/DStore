using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing6
{
    [TestClass]
    public class tstSupply
    {
       
        

        [TestMethod]
        public void InstanceOK()
        {
            clsSupply TheSupplier = new clsSupply();
            Assert.IsNotNull(TheSupplier);

        }
        [TestMethod]
        public void InStockPropertyOK()
        {
            // create an instance of the class we want ot create
            clsSupply TheSupplier = new clsSupply();

            //create some test data
            Boolean TestData = true;
            //assign the data to the property
            TheSupplier.InStock = TestData;
            //tesr to see if the two values are the samme
            Assert.AreEqual(TheSupplier.InStock, TestData);


        }
        [TestMethod]
        public void DeliveryDateAddedPropertyOK()
        {
            clsSupply TheSupplier = new clsSupply();
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property 
            TheSupplier.DeliveryDate = TestData;
            Assert.AreEqual(TheSupplier.DeliveryDate, TestData);
        }
        [TestMethod]
        public void ProductNamePropertyOK()
        {
            clsSupply TheSupplier = new clsSupply();
            //create some test data to assign to the property
            string TestData = "Name";
            //assign the data to the property
            TheSupplier.Name = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(TheSupplier.Name, TestData);
        }

        [TestMethod]
        public void ProductIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsSupply TheSupplier = new clsSupply();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            TheSupplier.ProductId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(TheSupplier.ProductId, TestData);
        }
        [TestMethod]
        public void QuantityNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsSupply TheSupplier = new clsSupply();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            TheSupplier.QuantityNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(TheSupplier.QuantityNo, TestData);
        }

        [TestMethod]
        public void PricePropertyOK()
        {
            //create an instance of the class we want to create
            clsSupply TheSupplier = new clsSupply();
            //create some test data to assign to the property
            double TestData = 1.5;
            //assign the data to the property
            TheSupplier.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(TheSupplier.Price, TestData);
        }


    }
}
