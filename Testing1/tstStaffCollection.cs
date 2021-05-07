using System;
using System.Collections.Generic;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingStaff
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffes = new clsStaffCollection();
            Assert.IsNotNull(AllStaffes);
        }
        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffes = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a lost of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the items of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.StaffStatus = true;
            TestItem.StaffNumber = 1;
            TestItem.StaffName = "jeff";
            TestItem.StaffCredit = 50;
            TestItem.StaffSalary = 500.0;
            TestItem.StaffDate = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaffes.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaffes.StaffList, TestList);
        }

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffes = new clsStaffCollection();
            //create some test data to assign to the property
            clsStaff TestStaff = new clsStaff();

            //set the properties of the test object
            TestStaff.StaffStatus = true;
            TestStaff.StaffNumber = 1;
            TestStaff.StaffName = "jeff";
            TestStaff.StaffCredit = 50;
            TestStaff.StaffDate = DateTime.Now.Date;
            TestStaff.StaffSalary = 500.0;
            //assign the data to the property
            AllStaffes.ThisStaff = TestStaff;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaffes.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffes = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a lost of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.StaffStatus = true;
            TestItem.StaffNumber = 1;
            TestItem.StaffName = "jeff";
            TestItem.StaffCredit = 50;
            TestItem.StaffSalary = 500.0;
            TestItem.StaffDate = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaffes.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaffes.Count, TestList.Count);
        }


        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffes = new clsStaffCollection();
            //create item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties          
            TestItem.StaffNumber = 20;
            TestItem.StaffName = "jeff9";
            TestItem.StaffStatus = true;
            TestItem.StaffCredit = 50;
            TestItem.StaffSalary = 500.0;
            TestItem.StaffDate = DateTime.Now.Date;
            //set ThisStaff to the test data
            AllStaffes.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaffes.Add();
            //set the primary key of the test data
            TestItem.StaffNumber = PrimaryKey;
            //find the record
            AllStaffes.ThisStaff.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStaffes.ThisStaff, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsStaffCollection AllStaffes = new clsStaffCollection();

            clsStaff TestItem = new clsStaff();

            Int32 PrimaryKey = 0;

            TestItem.StaffStatus = true;
            TestItem.StaffNumber = 21;
            TestItem.StaffName = "jeff4";
            TestItem.StaffDate = DateTime.Now.Date;
            TestItem.StaffCredit = 50;
            TestItem.StaffSalary = 500.0;

            AllStaffes.ThisStaff = TestItem;

            PrimaryKey = AllStaffes.Add();
            

            TestItem.StaffNumber = PrimaryKey;

            TestItem.StaffStatus = true;
            TestItem.StaffNumber = 22;
            TestItem.StaffName = "jeff3";
            TestItem.StaffDate = DateTime.Now.Date;
            TestItem.StaffCredit = 100;
            TestItem.StaffSalary = 200.0;
            AllStaffes.ThisStaff = TestItem;
            AllStaffes.Update();
            AllStaffes.ThisStaff.Find(PrimaryKey);
            Assert.AreEqual(AllStaffes.ThisStaff, TestItem);

            
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsStaffCollection AllStaffes = new clsStaffCollection();

            clsStaff TestItem = new clsStaff();

            Int32 PrimaryKey = 0;

            TestItem.StaffStatus = true;
            TestItem.StaffNumber = 23;
            TestItem.StaffName = "jeff";
            TestItem.StaffDate = DateTime.Now.Date;
            TestItem.StaffCredit = 50;
            TestItem.StaffSalary = 500.0;

            AllStaffes.ThisStaff = TestItem;

            PrimaryKey = AllStaffes.Add();

            TestItem.StaffNumber = PrimaryKey;

            AllStaffes.ThisStaff.Find(PrimaryKey);

            AllStaffes.Delete();

            Boolean Found = AllStaffes.ThisStaff.Find(PrimaryKey);

            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void FilterMethodOK()
        {
            clsStaffCollection AllStaffes = new clsStaffCollection();
            clsStaffCollection FilteredStaffes = new clsStaffCollection();
            FilteredStaffes.Filter("");
            Assert.AreEqual(AllStaffes.Count, FilteredStaffes.Count);
        }
        [TestMethod]
        public void FilterNoneFound()
        {
            clsStaffCollection FilteredStaffes = new clsStaffCollection();
            FilteredStaffes.Filter("nameless");
            
            Assert.AreEqual(0, FilteredStaffes.Count);
        }



    }

}
