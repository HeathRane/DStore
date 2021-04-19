using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestingCustomer
{
    [TestClass]
    public class tstCustomerCollectioin
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection allCustomers = new clsCustomerCollection;
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

    }
}
