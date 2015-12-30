using System;
using ForSonarQube;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1() {
            Assert.AreEqual(1, Program.Sub(0, 1, 2));
            //Assert.AreEqual(3, Program.Sub(3, 0, 5));
        }
    }
}
