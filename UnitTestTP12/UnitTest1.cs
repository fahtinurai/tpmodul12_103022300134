using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using tpmodul12_103022300134;

namespace UnitTestTP12
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestNegatif()
        {
            var form = new Form1();

            Assert.AreEqual("Negatif", form.CariTandaBilangan(-10));
        }

        [TestMethod]
        public void TestPositif()
        {
            var form = new Form1();
            Assert.AreEqual("Positif", form.CariTandaBilangan(15));
        }

        [TestMethod]
        public void TestNol()
        {
            var form = new Form1();
            Assert.AreEqual("Nol", form.CariTandaBilangan(0));
        }
    }
}
