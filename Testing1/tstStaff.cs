using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            // creat an instancec of the class we want tot create
            clsStaff AStaff = new clsStaff();
            // test to see if it exists
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        public void StaffNumberPropertyOK()
        {
            // create an instance of the class we want ot create
            clsStaff AStaff = new clsStaff();

            //create some test data
            Int32 TestData = 1;
            //assign the data to the property
            AStaff.StaffNumber = TestData;
            //tesr to see if the two values are the samme
            Assert.AreEqual(AStaff.StaffNumber, TestData);
        }

               [TestMethod]
        public void StaffStatusPropertyOK()
        {
            // create an instance of the class we want ot create
            clsStaff AStaff = new clsStaff();

            //create some test data
            Boolean TestData = true;
            //assign the data to the property
            AStaff.StaffStatus = TestData;
            //tesr to see if the two values are the samme
            Assert.AreEqual(AStaff.StaffStatus, TestData);


        }
        [TestMethod]
        public void StaffDatePropertyOK()
        {
            clsStaff AStaff = new clsStaff();
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property 
            AStaff.StaffDate = TestData;
            Assert.AreEqual(AStaff.StaffDate, TestData);
        }
        [TestMethod]
        public void StaffNamePropertyOK()
        {
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Name";
            //assign the data to the property
            AStaff.StaffName = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AStaff.StaffName, TestData);
        }

        [TestMethod]
        public void StaffCreditPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 100;
            //assign the data to the property
            AStaff.StaffCredit = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffCredit, TestData);
        }

        [TestMethod]
        public void StaffSalaryPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            double TestData = 1500.0;
            //assign the data to the property
            AStaff.StaffSalary = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffSalary, TestData);
        }
    }
}
