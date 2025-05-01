using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an Instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Test to see that it exists 
            Assert.IsNotNull(ACustomer);
        }
    }
}
