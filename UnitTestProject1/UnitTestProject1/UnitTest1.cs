using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var cl = new Class1();
            Assert.AreEqual(cl.add(1, 3), 4);
        }


        [TestMethod]
        public void TestMethod2()
        {
            System.Threading.Thread.Sleep(500);
        }

        [TestMethod]
        public void TestMethod3()
        {
        }
    }
}
