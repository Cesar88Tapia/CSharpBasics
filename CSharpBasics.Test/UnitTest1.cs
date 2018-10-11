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
        public void TestVideotutorial2()
        {
            Videotutorial1.Videotutorial1 v1 = new Videotutorial1.Videotutorial1();
            int res = v1.Execute();

            Assert.AreEqual(0, res);
        }
    }
}
