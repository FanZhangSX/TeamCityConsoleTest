using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeamCityConsoleTest;

namespace TeamCityConsoleTest.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int para = 0;

            Program.MySqure(1, out para);

            Assert.AreEqual(para, 1);

            Program.MySqure(2, out para);
            Assert.AreEqual(para, 4);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int para = 0;

            Program.MySqure(1, out para);

            Assert.AreEqual(para, 2);

            Program.MySqure(2, out para);
            Assert.AreEqual(para, 6);
        }
    }
}
