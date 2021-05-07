using System;
using System.Collections.Generic;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing6
{
    [TestClass]
    public class tstSupplyy
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
            // TheSupplier.ProductId = TestData;
            //test to see that the two values are the same
            // Assert.AreEqual(TheSupplier.ProductId, TestData);
        }
        [TestMethod]
        public void QuantityNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsSupply TheSupplier = new clsSupply();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            // TheSupplier.QuantityNo = TestData;
            //test to see that the two values are the same
            // Assert.AreEqual(TheSupplier.QuantityNo, TestData);
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

        [TestMethod]
        public void TestSupplierIDFound()
        {
            clsSupply Supplier = new clsSupply();

            // Boolean Found = false;

            Boolean OK = true;

            //Int32 CustomerID = 21;

            //  Found = aCustomer.Find(CustomerID);

            //if (aCustomer.CustomerID != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }




        [TestMethod]
        public void TestNameFound()
        {
            clsSupply Supplier = new clsSupply();
            //  Boolean Found = false;

            Boolean OK = true;

            //Int32 CustomerID = 21;

            //         Found = ACustomer.Find(CustomerID);

            //       if (ACustomer.CustomerFullName != "Diogo Rodrigues")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void InStockFound()
        {
            clsSupply Supplier = new clsSupply();
            Boolean Found = false;

            Boolean OK = true;

            Int32 ProductID = 2;

            Found = Supplier.Find(ProductID);

            if (Supplier.InStock != true)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void PriceExtremeMin()
        {
            clsStock AnStock = new clsStock();

            String Error = "";

            //string StockPrice = "-100000000";

            // Error = AnStock.Valid(StockAvailability, StockDescription, StockPrice);

            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]

        public void ValidMethodOk()
        {
            clsStock AnStock = new clsStock();

            string Error = "";

            //Error = AnStock.Valid(StockAvailability, StockDescription, StockPrice);

            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void NamextremeMax()
        {
            clsStock AnStock = new clsStock();

            String Error = "";

            string StockDescription = "";

            StockDescription = StockDescription.PadRight(1000, 'a');

            //Error = AnStock.Valid(StockAvailability, StockDescription, StockPrice);

            Assert.AreNotEqual(Error, "");
        }


        public void PriceMinPlusOne()
        {
            clsStock AnStock = new clsStock();

            String Error = "";

            //string StockAvailability = "1";

            //Error = AnStock.Valid(StockAvailability, StockDescription, StockPrice);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void QuantityExtremeMin()
        {
            clsStock AnStock = new clsStock();

            String Error = "";

            // string StockAvailability = "-100000";

            //Error = AnStock.Valid(StockAvailability, StockDescription, StockPrice);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void QuantityMinLessOne()
        {
            clsStock AnStock = new clsStock();

            String Error = "";

            // string StockAvailability = "-1";

            //Error = AnStock.Valid(StockAvailability, StockDescription, StockPrice);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void QuantityMin()
        {
            clsStock AnStock = new clsStock();

            String Error = "";

            // string StockAvailability = "0";

            //Error = AnStock.Valid(StockAvailability, StockDescription, StockPrice);

            Console.WriteLine(Error);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]

        public void QuantityInvalidDataType()
        {
            clsSupply Supplier = new clsSupply();

            String Error = "";

            string SupplierPrice = "ten pounds";

            // Error = string SupplierInStock, string SupplierName, string SupplierPrice)

            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]

        public void QuantityMid()
        {
            clsStock AnStock = new clsStock();

            String Error = "";

            string StockDescription = "";

            StockDescription = StockDescription.PadRight(100, 'a');

            //  Error = AnStock.Valid(StockAvailability, StockDescription, StockPrice);



            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TestDeliveryDateFound()
        {
            clsSupply Supplier = new clsSupply();

            Boolean Found = false;

            Boolean OK = true;

            Int32 ProductID = 2;

            Found = Supplier.Find(ProductID);

            if (Supplier.DeliveryDate != Convert.ToDateTime("15/04/2021"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestQuantityFound()
        {
            clsSupply Supplier = new clsSupply();
            Boolean Found = false;

            Boolean OKs = true;

            

            Int32 ProductID = 2;

            Found = Supplier.Find(ProductID);

            if (Supplier.Quantity != 3213)
            {
                OKs = false;
            }
            Assert.IsTrue(OKs);
        }
        [TestMethod]
        public void TestClassCollectionSupplyOK()
        {
            clsSupplyCollection list = new clsSupplyCollection();
            Assert.IsNotNull(list);
        }

       
    }

   
}


