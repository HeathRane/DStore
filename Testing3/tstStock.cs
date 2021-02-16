using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            // instantiate class to create
            clsStock AProduct = new clsStock();
            // test to see if it exists
            Assert.IsNotNull(AProduct);
        }
    }
}
