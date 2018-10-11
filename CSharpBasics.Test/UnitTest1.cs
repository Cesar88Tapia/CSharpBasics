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

        public void TestConsoleApp6()
        {
            ConsoleApp6.ConsoleApp6 v6 = new ConsoleApp6.ConsoleApp6();
            string res = v6.Execute();
            bool res = v6.Execute();

            Assert.AreEqual(" ", true, res);
        }

        public void TestConsoleApp7()
        {
            ConsoleApp7.ConsoleApp7 v7 = new ConsoleApp7.ConsoleApp7();
            string res = v7.Execute();

            Assert.AreEqual(" ", res);
        }

        public void TestConsoleApp8()
        {
            ConsoleApp8.ConsoleApp8 v8 = new ConsoleApp8.ConsoleApp8();
            string res = v8.Execute();

            Assert.AreEqual(" ", res);
        }

        public void TestConsoleApp9()
        {
            ConsoleApp9.ConsoleApp9 v9 = new ConsoleApp9.ConsoleApp9();
            int res = v9.Execute();
            string res = v9.Execute();

            Assert.AreEqual(0, " ", res);
        }

        public void TestConsoleApp10()
        {
            ConsoleApp10.ConsoleApp10 v10 = new ConsoleApp10.ConsoleApp10();
            int res = v10.Execute();

            Assert.AreEqual(0, res);
        }

        public void TestConsoleApp11()
        {
            ConsoleApp11.ConsoleApp11 v11 = new ConsoleApp11.ConsoleApp11();
            int res = v11.Execute();
            string res = v11.Execute();

            Assert.AreEqual(0, " ", res);
        }

        public void TestConsoleApp13()
        {
            ConsoleApp13.ConsoleApp13 v13 = new ConsoleApp13.ConsoleApp13();
            int res = v13.Execute();
            string res = v13.Execute();
        }
    }
}
