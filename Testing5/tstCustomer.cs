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

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer theCustomer = new clsCustomer();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerId = 21;
            //invoe the method 
            Found = theCustomer.Find(CustomerId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIdNoFound()
        {
            //create an instance of the class we want to create
            clsCustomer theCustomer = new clsCustomer();
            //Boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with method
            Int32 CustomerId = 21;
            //invoke the method
            Found = theCustomer.Find(CustomerId);
            //check the customer id
            if (theCustomer.CustomerId != 21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue (OK);
        }

        [TestMethod]
        public void TestCustomerNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer theCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 21;
            //invoke the method
            Found = theCustomer.Find(CustomerId);
            //check the customer name
            if (theCustomer.Name != "Zeynep")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerRegisteredDateFound()
        {
            //create an instance of the class we want to create
            clsCustomer theCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 21;
            //invoke the method
            Found = theCustomer.Find(CustomerId);
            //check the registered date
            if (theCustomer.CustomerRegisteredDate != Convert.ToDateTime("05/03/2021"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductIdNoFound()
        {
            //create an instance of the class we want to create
            clsCustomer theCustomer = new clsCustomer();
            //Boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with method
            Int32 CustomerId = 21;
            //invoke the method
            Found = theCustomer.Find(CustomerId);
            //check the product id
            if (theCustomer.ProductId != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPointNoFound()
        {
            //create an instance of the class we want to create
            clsCustomer theCustomer = new clsCustomer();
            //Boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with method
            Int32 CustomerId = 21;
            //invoke the method
            Found = theCustomer.Find(CustomerId);
            //check the customer point
            if (theCustomer.Point != 1.5)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestActiveNoFound()
        {
            //create an instance of the class we want to create
            clsCustomer theCustomer = new clsCustomer();
            //Boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with method
            Int32 CustomerId = 21;
            //invoke the method
            Found = theCustomer.Find(CustomerId);
            //check the customer activity
            if (theCustomer.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
