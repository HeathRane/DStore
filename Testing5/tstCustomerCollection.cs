using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestingCustomer
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection allCustomers = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(allCustomers);
        }

        [TestMethod]
        public void CustomerListOK ()
        {
            //create an instance of the class we want to create
            clsCustomerCollection allCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerId = 4;
            TestItem.Name = "Zeynep Tugce";
            TestItem.CustomerRegisteredDate = DateTime.Now.Date;
            TestItem.Point = 0;
            TestItem.ProductId = 40;
            //addthe item to the test list
            TestList.Add(TestItem);
            //assign the data tp the property
            allCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(allCustomers.CustomerList, TestList);
        }       

        [TestMethod]
        public void ThisCustomerPropertyOK ()
        {
            clsCustomerCollection allCustomers = new clsCustomerCollection();

            clsCustomer TestCustomer = new clsCustomer();

            TestCustomer.Active = true;
            TestCustomer.CustomerId = 4;
            TestCustomer.Name = "Zeynep Tugce";
            TestCustomer.CustomerRegisteredDate = DateTime.Now.Date;
            TestCustomer.ProductId = 40;
            TestCustomer.Point = 0;

            allCustomers.ThisCustomer = TestCustomer;

            Assert.AreEqual(allCustomers.ThisCustomer, TestCustomer);
            
        }

        [TestMethod]
        public void ListAndCountOK ()
        {
            clsCustomerCollection allCustomers = new clsCustomerCollection();

            List<clsCustomer> TestList = new List<clsCustomer>();

            clsCustomer TestItem = new clsCustomer();

            TestItem.Active = true;
            TestItem.CustomerId = 4;
            TestItem.Name = "Zeynep Tugce";
            TestItem.CustomerRegisteredDate = DateTime.Now.Date;
            TestItem.ProductId = 40;
            TestItem.Point = 0;

            TestList.Add(TestItem);

            allCustomers.CustomerList = TestList;

            Assert.AreEqual(allCustomers.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsCustomerCollection allCustomers = new clsCustomerCollection();

            clsCustomer TestItem = new clsCustomer();

            Int32 PrimaryKey = 0;

            TestItem.Active = true;
            TestItem.CustomerId = 4;
            TestItem.Name = "Zeynep Tugce";
            TestItem.CustomerRegisteredDate = DateTime.Now.Date;
            TestItem.ProductId = 40;
            TestItem.Point = 0;

            allCustomers.ThisCustomer = TestItem;

            PrimaryKey = allCustomers.Add();

            TestItem.CustomerId = PrimaryKey;

            allCustomers.ThisCustomer.Find(PrimaryKey);

            Assert.AreEqual(allCustomers.ThisCustomer, TestItem);

        }

        [TestMethod]
        public void UpdateMethodOK()
        {          
                clsCustomerCollection allCustomers = new clsCustomerCollection();

                clsCustomer TestItem = new clsCustomer();

                Int32 PrimaryKey = 0;

                TestItem.Active = true;
                TestItem.CustomerId = 4;
                TestItem.Name = "Zeynep Tugce";
                TestItem.CustomerRegisteredDate = DateTime.Now.Date;
                TestItem.ProductId = 40;
                TestItem.Point = 0;

                allCustomers.ThisCustomer = TestItem;

                PrimaryKey = allCustomers.Update();

                TestItem.CustomerId = PrimaryKey;

                allCustomers.ThisCustomer.Find(PrimaryKey);

                Assert.AreEqual(allCustomers.ThisCustomer, TestItem);

            }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsCustomerCollection allCustomers = new clsCustomerCollection();

            clsCustomer TestItem = new clsCustomer();

            Int32 PrimaryKey = 0;

            TestItem.Active = true;
            TestItem.CustomerId = 4;
            TestItem.Name = "Zeynep Tugce";
            TestItem.CustomerRegisteredDate = DateTime.Now.Date;
            TestItem.ProductId = 40;
            TestItem.Point = 0;

            allCustomers.ThisCustomer = TestItem;

            PrimaryKey = allCustomers.Add();

            TestItem.CustomerId = PrimaryKey;

            allCustomers.ThisCustomer.Find(PrimaryKey);

            allCustomers.Delete();

            Boolean Found = allCustomers.ThisCustomer.Find(PrimaryKey);

            Assert.IsFalse(Found);

        }

    }

    }

