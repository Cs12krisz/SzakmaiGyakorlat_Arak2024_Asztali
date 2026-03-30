using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArakCLI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArakCLI.Tests
{
    [TestClass()]
    public class ArakTests
    {
        [DataRow(5000, 10000, -5000)]
        [DataRow(10000, 5000, 5000)]
        [DataRow(5000, 5000, 0)]
        [TestMethod()]
        public void ValtozasTest(int december, int januar, int elvart)
        {
            Arak arak = new Arak(december, januar, "00000", "Termék");
            Assert.AreEqual(elvart, arak.Valtozas());
        }
    }
}