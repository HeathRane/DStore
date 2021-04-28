using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingCustomer
{
    [TestClass]
    public class tstCustomer
    {
        //good test data
        //create some data to pass to the test 
        string Name = "Zeynep Tugce";
        string CustomerRegisteredDate = "07/03/2021";
        string Point = "0";
        string ProductId = "1";

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
            Int32 CustomerId = 4;
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
            Int32 CustomerId = 4;
            //invoke the method
            Found = theCustomer.Find(CustomerId);
            //check the customer id
            if (theCustomer.CustomerId != 4)
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
            Int32 CustomerId = 4;
            //invoke the method
            Found = theCustomer.Find(CustomerId);
            //check the customer name
            if (theCustomer.Name != "Zeynep Tugce")
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
            Int32 CustomerId = 4;
            //invoke the method
            Found = theCustomer.Find(CustomerId);
            //check the registered date
            if (theCustomer.CustomerRegisteredDate != Convert.ToDateTime("07/03/2021"))
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
            Int32 CustomerId = 4;
            //invoke the method
            Found = theCustomer.Find(CustomerId);
            //check the product id
            if (theCustomer.ProductId != 40)
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
            Int32 CustomerId = 4;
            //invoke the method
            Found = theCustomer.Find(CustomerId);
            //check the customer point
            if (theCustomer.Point != 0)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsCustomer theCustomer = new clsCustomer();
            //Boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with method
            Int32 CustomerId = 4;
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
        
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer theCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = theCustomer.Valid(CustomerRegisteredDate, Name, Point, ProductId);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer theCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Name = "";
            //invoke the method
            Error = theCustomer.Valid(CustomerRegisteredDate, Name, Point, ProductId);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        public void CustomerNameMin()

        {

            //create an instance of the class we want to create

            clsCustomer theCustomer = new clsCustomer();

            //string variable to store any error message

            String Error = "";

            //create some test data to pass to the method

            string Name = "Z"; //this should be ok

            //invoke the method

            Error = theCustomer.Valid(CustomerRegisteredDate, Name, Point, ProductId);

            //test to see that the result is correct

            Assert.AreEqual(Error, "");

        }



        [TestMethod]

        public void CustomerNameMinPlusOne()

        {

            //create an instance of the class we want to create

            clsCustomer theCustomer = new clsCustomer();

            //string variable to store any error message

            String Error = "";

            //create some test data to pass to the method

            string Name = "Ze"; //this should be ok

            //invoke the method

            Error = theCustomer.Valid(CustomerRegisteredDate, Name, Point, ProductId);
            
            //test to see that the result is correct

            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void CustomerNameMaxLessOne()

        {

            //create an instance of the class we want to create

            clsCustomer theCustomer = new clsCustomer();

            //string variable to store any error message

            String Error = "";

            //create some test data to pass to the method

            string Name = "ZeynepZeynepZeynepZeynepZeynepZeynepZeynepZeynepZ"; //this should be ok

            //invoke the method

            Error = theCustomer.Valid(CustomerRegisteredDate, Name, Point, ProductId);

            //test to see that the result is correct

            Assert.AreEqual(Error, "");

        }
        

        [TestMethod]

        public void CustomerNameMax()

        {

            //create an instance of the class we want to create

            clsCustomer theCustomer = new clsCustomer();

            //string variable to store any error message

            String Error = "";

            //create some test data to pass to the method

            string Name = "ZeynepZeynepZeynepZeynepZeynepZeynepZeynepZeynepZe"; //this should be ok

            //invoke the method

            Error = theCustomer.Valid(CustomerRegisteredDate, Name, Point, ProductId);

            //test to see that the result is correct

            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void CustomerNameMaxPlusOne()

        {

            //create an instance of the class we want to create

            clsCustomer theCustomer = new clsCustomer();

            //string variable to store any error message

            String Error = "";

            //create some test data to pass to the method

            string Name = "ZeynepZeynepZeynepZeynepZeynepZeynepZeynepZeynepZey"; //this should fail

            //invoke the method

            Error = theCustomer.Valid(CustomerRegisteredDate, Name, Point, ProductId);

            //test to see that the result is correct

            Assert.AreNotEqual(Error, "");

        }



        [TestMethod]

        public void CustomerNameMid()

        {

            //create an instance of the class we want to create

            clsCustomer theCustomer = new clsCustomer();

            //string variable to store any error message

            String Error = "";

            //create some test data to pass to the method

            string Name = "ZeynepZeynepZeynepZeynepZ"; //this should be ok


            //invoke the method

            Error = theCustomer.Valid(CustomerRegisteredDate, Name, Point, ProductId);

            //test to see that the result is correct

            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void CustomerNameExtremeMax()

        {

            //create an instance of the class we want to create

            clsCustomer theCustomer = new clsCustomer();

            //string variable to store any error message

            String Error = "";

            //create some test data to pass to the method

            string Name = ""; 

            Name = Name.PadRight(500, 'Z'); //this should fail

            //invoke the method

            Error = theCustomer.Valid(CustomerRegisteredDate, Name, Point, ProductId); 

            //test to see that the result is correct

            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]

        public void RegisteredDateExtremeMin()

        {

            //create an instance of the class we want to create

            clsCustomer theCustomer = new clsCustomer();

            //string variable to store any error message

            String Error = "";

            //create a variable to store the test date data

            DateTime TestDate;

            //set the date totodays date

            TestDate = DateTime.Now.Date;

            //change the date to whatever the date is less 100 years

            TestDate = TestDate.AddYears(-100);

            //convert the date variable to a string variable

            string CustomerRegisteredDate = TestDate.ToString();

            //invoke the method

            Error = theCustomer.Valid(CustomerRegisteredDate, Name, Point, ProductId);

            //test to see that the result is correct

            Assert.AreNotEqual(Error, "");

        }



        [TestMethod]

        public void RegisteredDateMinLessOne()

        {

            //create an instance of the class we want to create

            clsCustomer theCustomer = new clsCustomer();

            //string variable to store any error message

            String Error = "";

            //create a variable to store the test date data

            DateTime TestDate;

            //set the date totodays date

            TestDate = DateTime.Now.Date;

            //change the date to whatever the date is less 1 day

            TestDate = TestDate.AddMonths(-6);

            //convert the date variable to a string variable

            string CustomerRegisteredDate = TestDate.ToString();

            //invoke the method

            Error = theCustomer.Valid(CustomerRegisteredDate, Name, Point, ProductId);

            //test to see that the result is correct

            Assert.AreNotEqual(Error, "");

        }



        [TestMethod]

        public void RegisteredDateMin()

        {

            //create an instance of the class we want to create

            clsCustomer theCustomer = new clsCustomer();

            //string variable to store any error message

            String Error = "";

            //create a variable to store the test date data

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            //set the date totodays date

            TestDate = TestDate.AddMonths(-5);

            //convert the date variable to a string variable

            string CustomerRegisteredDate = TestDate.ToString();

            //invoke the method

            Error = theCustomer.Valid(CustomerRegisteredDate, Name, Point, ProductId);

            //test to see that the result is correct

            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void RegistereDateMinPlusOne()

        {

            //create an instance of the class we want to create

            clsCustomer theCustomer = new clsCustomer();

            //string variable to store any error message

            String Error = "";

            //create a variable to store the test date data

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            //set the date totodays date

            TestDate = TestDate.AddMonths(-4);

            //change the date to whatever the date is plus 1 day

            //convert the date variable to a string variable

            string CustomerRegisteredDate = TestDate.ToString();

            //invoke the method

            Error = theCustomer.Valid(CustomerRegisteredDate, Name, Point, ProductId);

            //test to see that the result is correct

            Assert.AreEqual(Error, "");

        }



        [TestMethod]

        public void RegisteredDateExtremeMax()

        {

            //create an instance of the class we want to create

            clsCustomer theCustomer = new clsCustomer();

            //string variable to store any error message

            String Error = "";

            //create a variable to store the test date data

            DateTime TestDate;

            //set the date totodays date

            TestDate = DateTime.Now.Date;

            //change the date to whatever the date is plus 100 years

            TestDate = TestDate.AddYears(100);

            //convert the date variable to a string variable

            string CustomerRegisteredDate = TestDate.ToString();

            //invoke the method

            Error = theCustomer.Valid(CustomerRegisteredDate, Name, Point, ProductId);

            //test to see that the result is correct

            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]

        public void RegisteredDateMaxPlusOne()

        {

            //create an instance of the class we want to create

            clsCustomer theCustomer = new clsCustomer();

            //string variable to store any error message

            String Error = "";

            //create a variable to store the test date data

            DateTime TestDate;

            //set the date totodays date

            TestDate = DateTime.Now.Date;

            //change the date to whatever the date is plus 100 years

            TestDate = TestDate.AddDays(1);

            //convert the date variable to a string variable

            string CustomerRegisteredDate = TestDate.ToString();

            //invoke the method

            Error = theCustomer.Valid(CustomerRegisteredDate, Name, Point, ProductId);

            //test to see that the result is correct

            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]

        public void RegisteredDateMax()

        {

            //create an instance of the class we want to create

            clsCustomer theCustomer = new clsCustomer();

            //string variable to store any error message

            String Error = "";

            //create a variable to store the test date data

            DateTime TestDate;

            //set the date totodays date

            TestDate = DateTime.Now.Date;

                 

            //convert the date variable to a string variable

            string CustomerRegisteredDate = TestDate.ToString();

            //invoke the method

            Error = theCustomer.Valid(CustomerRegisteredDate, Name, Point, ProductId);

            //test to see that the result is correct

            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void RegisteredDateMaxLessOne()

        {

            //create an instance of the class we want to create

            clsCustomer theCustomer = new clsCustomer();

            //string variable to store any error message

            String Error = "";

            //create a variable to store the test date data

            DateTime TestDate;

            //set the date totodays date

            TestDate = DateTime.Now.Date;

            //change the date to whatever the date is plus 100 years

            TestDate = TestDate.AddDays(-1);

            //convert the date variable to a string variable

            string CustomerRegisteredDate = TestDate.ToString();

            //invoke the method

            Error = theCustomer.Valid(CustomerRegisteredDate, Name, Point, ProductId);

            //test to see that the result is correct

            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void RegisteredDateInvalidData()

        {

            //create an instance of the class we want to create

            clsCustomer theCustomer = new clsCustomer();

            //string variable to store any error message

            String Error = "";
                   
            string CustomerRegisteredDate = "this is not a date";

            //invoke the method

            Error = theCustomer.Valid(CustomerRegisteredDate, Name, Point, ProductId);

            //test to see that the result is correct

            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PointMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer theCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Point = "";
            //invoke the method
            Error = theCustomer.Valid(CustomerRegisteredDate, Name, Point, ProductId);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        public void PointMin()

        {

            //create an instance of the class we want to create

            clsCustomer theCustomer = new clsCustomer();

            //string variable to store any error message

            String Error = "";

            //create some test data to pass to the method

            string Point = "0.1"; //this should be ok

            //invoke the method

            Error = theCustomer.Valid(CustomerRegisteredDate, Name, Point, ProductId);

            //test to see that the result is correct

            Assert.AreEqual(Error, "");

        }



        [TestMethod]

        public void PointMinPlusOne()

        {

            //create an instance of the class we want to create

            clsCustomer theCustomer = new clsCustomer();

            //string variable to store any error message

            String Error = "";

            //create some test data to pass to the method

            string Name = "1.1"; //this should be ok

            //invoke the method

            Error = theCustomer.Valid(CustomerRegisteredDate, Name, Point, ProductId);

            //test to see that the result is correct

            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ProductIdMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer theCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string ProductId = "";
            //invoke the method
            Error = theCustomer.Valid(CustomerRegisteredDate, Name, Point, ProductId);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        public void ProductIdMin()

        {

            //create an instance of the class we want to create

            clsCustomer theCustomer = new clsCustomer();

            //string variable to store any error message

            String Error = "";

            //create some test data to pass to the method

            string ProductId = "1"; //this should be ok

            //invoke the method

            Error = theCustomer.Valid(CustomerRegisteredDate, Name, Point, ProductId);

            //test to see that the result is correct

            Assert.AreEqual(Error, "");

        }



        [TestMethod]

        public void ProductIdMinPlusOne()

        {

            //create an instance of the class we want to create

            clsCustomer theCustomer = new clsCustomer();

            //string variable to store any error message

            String Error = "";

            //create some test data to pass to the method

            string ProductId = "2"; //this should be ok

            //invoke the method

            Error = theCustomer.Valid(CustomerRegisteredDate, Name, Point, ProductId);

            //test to see that the result is correct

            Assert.AreEqual(Error, "");

        }


    }
}
