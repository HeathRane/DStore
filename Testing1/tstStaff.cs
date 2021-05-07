using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {
        //good test data
        //creat some test data to pass the method
        
        string StaffName = "jacky";
        string StaffStatus = "true";
        string StaffDate = DateTime.Now.Date.ToString();
        string StaffCredit = "100";
        string StaffSalary = "200.0";
        string StaffNumber = "1";
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

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StaffNumber = 2;
            //invoke the method
            Found = AStaff.Find(StaffNumber);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffNoFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffNumber = 2;
            //invoke the method
            Found = AStaff.Find(StaffNumber);
            //check the staffnumber
            if (AStaff.StaffNumber != 2)
            {
                OK = false;
            }
            //test is the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffNameNoFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffNumber = 2;
            //invoke the method
            Found = AStaff.Find(StaffNumber);
            //check
            if (AStaff.StaffName != "jacky")
            {
                OK = false;
            }
            //test is the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffStatusNoFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffNumber = 2;
            //invoke the method
            Found = AStaff.Find(StaffNumber);
            //check
            if (AStaff.StaffStatus != true)
            {
                OK = false;
            }
            //test is the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffDateNoFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffNumber = 2;
            //invoke the method
            Found = AStaff.Find(StaffNumber);
            //check
            if (AStaff.StaffDate != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            //test is the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffCreditNoFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffNumber = 2;
            //invoke the method
            Found = AStaff.Find(StaffNumber);
            //check
            if (AStaff.StaffCredit != 100)
            {
                OK = false;
            }
            //test is the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStaffSalaryNoFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffNumber = 2;
            //invoke the method
            Found = AStaff.Find(StaffNumber);
            //check
            if (AStaff.StaffSalary != 1000.0)
            {
                OK = false;
            }
            //test is the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffDate,StaffCredit,StaffSalary,StaffStatus,StaffNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = "";//this should trigger an error
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffDate, StaffCredit, StaffSalary, StaffStatus, StaffNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = "a";
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffDate, StaffCredit, StaffSalary, StaffStatus, StaffNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = "aa";
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffDate, StaffCredit, StaffSalary, StaffStatus, StaffNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = "aaaaaaa";
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffDate, StaffCredit, StaffSalary, StaffStatus, StaffNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = "aaaaaaaa";
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffDate, StaffCredit, StaffSalary, StaffStatus, StaffNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = "aaaa";
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffDate, StaffCredit, StaffSalary, StaffStatus, StaffNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = "aaaaaaaaa";
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffDate, StaffCredit, StaffSalary, StaffStatus, StaffNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = "";
            StaffName = StaffName.PadRight(500, 'a');
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffDate, StaffCredit, StaffSalary, StaffStatus, StaffNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string StaffDate = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffDate, StaffCredit, StaffSalary, StaffStatus, StaffNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string StaffDate = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffDate, StaffCredit, StaffSalary, StaffStatus, StaffNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffDateMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string StaffDate = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffDate, StaffCredit, StaffSalary, StaffStatus, StaffNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string StaffDate = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffDate, StaffCredit, StaffSalary, StaffStatus, StaffNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string StaffDate = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffDate, StaffCredit, StaffSalary, StaffStatus, StaffNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffDateInvalidData()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //set the StaffDate to a  non date value
          
            string StaffDate = "this is not a date!";
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffDate, StaffCredit, StaffSalary, StaffStatus, StaffNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

       
    }
}

