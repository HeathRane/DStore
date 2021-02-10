using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class tstOrders
    {
        [TestMethod]
        public void instanceOK()
        {   //create an instanceof the class we want to create
            clsOrders AnOrder = new clsOrders();

            Assert.IsNotNull(AnOrder);
        
        }
    }
}
