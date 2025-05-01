using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class tstOrderLine
    {
        [TestMethod]
        public void InstanceOK1()
        {
            // create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            // test that it exists
            Assert.IsNotNull(AnOrderLine);
        }
    }
}
