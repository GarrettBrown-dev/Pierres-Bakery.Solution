using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
    [TestClass]

    public class PastryTest
    {
        [TestMethod]
        public void GetPastry_CreatesAnInstanceOfPastry_Pastry()
        {
            Pastry newPastry = new Pastry(0, 0);
            Assert.AreEqual(typeof(Pastry), oldPastry.GetType());
        }
    }
}