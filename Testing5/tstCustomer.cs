using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing5
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer theCustomer = new clsCustomer();
            Assert.IsNotNull(theCustomer);

        }

        [TestMethod]
        public void CustomerActivityPropertyOK()
        {
            // create an instance of the class we want ot create
            clsCustomer theCustomer = new clsCustomer();

            //create some test data
            Boolean TestData = true;
            //assign the data to the property
            theCustomer.Active = TestData;
            //tesr to see if the two values are the samme
            Assert.AreEqual(theCustomer.Active, TestData);
        }

        [TestMethod]
        public void CustomerRegisteredDatePropertyOK()
        {
            clsCustomer theCustomer = new clsCustomer();
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property 
            theCustomer.CustomerRegisteredDate = TestData;
            Assert.AreEqual(theCustomer.CustomerRegisteredDate, TestData);
        }

        [TestMethod]
        public void CustomerNamePropertyOK()
        {
            clsCustomer theCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Name";
            //assign the data to the property
            theCustomer.Name = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(theCustomer.Name, TestData);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer theCustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            theCustomer.CustomerId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(theCustomer.CustomerId, TestData);
        }

        [TestMethod]
        public void ProductIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer theCustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            theCustomer.ProductId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(theCustomer.ProductId, TestData);
        }

        [TestMethod]
        public void PointPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer theCustomer = new clsCustomer();
            //create some test data to assign to the property
            double TestData = 1.5;
            //assign the data to the property
            theCustomer.Point = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(theCustomer.Point, TestData);
        }

    }
}
