using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;

namespace Testing6
{
    [TestClass]
    public class tstSupplyCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsSupplyCollection ded = new clsSupplyCollection();
            Assert.IsNotNull(ded);
        }
        [TestMethod]
        public void TestCollectionOK()
        {
            clsSupplyCollection allSupply = new clsSupplyCollection();

            List<clsSupply> testList = new List<clsSupply>();
            clsSupply Supplier = new clsSupply();
            Supplier.InStock = true;
            Supplier.Price = 3;
            Supplier.ProductID = 5;
            Supplier.Quantity = 6;
            Supplier.Name = " lolo";
            Supplier.DeliveryDate = DateTime.Now.Date;
            testList.Add(Supplier);
            allSupply.SupplyList = testList;
            Assert.AreEqual(allSupply.SupplyList, testList);

        }
        [TestMethod]
        public void TestCountOK()
        {
            clsSupplyCollection allSupply = new clsSupplyCollection();

            Int32 Somecount = 0;
            allSupply.Count = Somecount;
            Assert.AreEqual(allSupply.Count, Somecount);
        }
        [TestMethod]
        public void ListandCountOK()
        {
            clsSupplyCollection allSupply = new clsSupplyCollection();

            List<clsSupply> testList = new List<clsSupply>();
            clsSupply Supplier = new clsSupply();
            Supplier.InStock = true;
            Supplier.Price = 3;
            Supplier.ProductID = 5;
            Supplier.Quantity = 6;
            Supplier.Name = " lolo";
            Supplier.DeliveryDate = DateTime.Now.Date;
            testList.Add(Supplier);
            allSupply.SupplyList = testList;
            Assert.AreEqual(allSupply.Count, testList.Count);

        }
        [TestMethod]
        public void AddMethodOK()
        {


            clsSupplyCollection collection = new clsSupplyCollection();
            clsSupply TestClass = new clsSupply();
            TestClass.InStock = true;
            TestClass.Name = "cos tamno";
            TestClass.Price = 43;
            TestClass.Quantity = 22;
            TestClass.DeliveryDate = DateTime.Now.Date;
            collection.ThisSupply = TestClass;
            Int32 PrimaryKey = collection.Add();
            PrimaryKey = TestClass.ProductID;
            Assert.AreEqual(collection.ThisSupply, TestClass);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {


            clsSupplyCollection collection = new clsSupplyCollection();
            clsSupply TestClass = new clsSupply();
            TestClass.InStock = true;
            TestClass.Name = "cos tamno";
            TestClass.Price = 43;
            TestClass.Quantity = 22;
            TestClass.DeliveryDate = DateTime.Now.Date;
            collection.ThisSupply = TestClass;
            Int32 PrimaryKey = collection.Add();
            PrimaryKey = TestClass.ProductID;
            TestClass.InStock = false;
            TestClass.Name = "different input";
            TestClass.Price = 8;
            TestClass.Quantity = 2342;
            TestClass.DeliveryDate = DateTime.Now.Date;

            collection.ThisSupply = TestClass;
            collection.Update();
            collection.ThisSupply.Find(PrimaryKey);

            Assert.AreEqual(collection.ThisSupply, TestClass);
        }


        [TestMethod]
        public void DeleteMethodOK()
        {


            clsSupplyCollection collection = new clsSupplyCollection();
            clsSupply TestClass = new clsSupply();
            TestClass.InStock = true;
            TestClass.Name = "cos tamno";
            TestClass.Price = 43;
            TestClass.Quantity = 22;
            TestClass.DeliveryDate = DateTime.Now.Date;
            collection.ThisSupply = TestClass;
            Int32 PrimaryKey = collection.Add();
            TestClass.ProductID = PrimaryKey;
            collection.Delete();
            Boolean Found = collection.ThisSupply.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByNameMethodOK()
        {
            clsSupplyCollection collection = new clsSupplyCollection();
            clsSupplyCollection filteredNames = new clsSupplyCollection();
            //apply a blank string (should return all records); 
            filteredNames.ReportByName("");
            // test to see that the two values are the same 
            Assert.AreEqual(collection.Count, filteredNames.Count); 
        }

        [TestMethod]

        public void ReportByNameNoneFound()
        {
            clsSupplyCollection filteredNames = new clsSupplyCollection();
            //apply a name that doesnt exist 
            filteredNames.ReportByName("nie ma takeigo");
            // test to see that there are no records 
            Assert.AreEqual(0, filteredNames.Count);
        }
    }
}
