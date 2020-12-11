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
            Assert.AreEqual(typeof(Pastry), newPastry.GetType());
        }
        [TestMethod]
        public void SetObject_SetObject_Pastry()
        {
            int quant = 0;
            int price = 0;
            Pastry newPastry = new Pastry(quant, price);
        }
        [TestMethod]
        public void PastryPrice_ShowPriceForSinglePastry_Price()
        {
            Assert.AreEqual(2, Pastry.PastryPrice(1));
        }
        [TestMethod]
        public void PastryPrice_ShowPriceFor3Pastries_5()
        {
            Assert.AreEqual(0, Pastry.PastryPrice(3));
        }
    }
}