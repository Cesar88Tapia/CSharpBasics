using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpBasics;

namespace CSharpBasics.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestVideotutorial1()
        {
            Videotutorial1.Videotutorial1 v1 = new Videotutorial1.Videotutorial1();
            int res = v1.Execute();

            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void TestConsoleApp2()
        {
            ConsoleApp2.ConsoleApp2 v2 = new ConsoleApp2.ConsoleApp2();
            int res = v2.Execute();
            decimal res = v2.Execute();
            bool res = v2.Execute();
            string res = v2.Execute();

            Assert.AreEqual(0, 0, true, " ", res);
        }

        public void TestConsoleApp3()
        {
            ConsoleApp3.ConsoleApp3 v3 = new ConsoleApp3.ConsoleApp3();
            int res = v3.Execute();
            string res = v3.Execute();

            Assert.AreEqual(0, " ", res);
        }

        public void TestConsoleApp4()
        {
            ConsoleApp4.ConsoleApp4 v4 = new ConsoleApp4.ConsoleApp4();
            int res = v4.Execute();

            Assert.AreEqual(0, res);
        }
    }
}
