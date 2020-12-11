using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
    [TestClass]

    public class BagelTest
    {
        [TestMethod]
        public void GetBagel_CreatesAnInstanceOfBagel_Bagel()
        {
            Bagel newBagel = new Bagel(0, 0);
            Assert.AreEqual(typeof(Bagel), newBagel.GetType());
        }
        [TestMethod]
        public void SetObject_SetObject_Bagel()
        {
            int quant = 0;
            int price = 0;
            Bagel newBagel = new Bagel(quant, price);
        }
        [TestMethod]
        public void BagelPrice_ShowPriceForSingleBagel_Price()
        {
            Assert.AreEqual(2, Pastry.PastryPrice(1));
        }
        [TestMethod]
        public void BagelPrice_ShowPriceFor4Bagels_4()
        {
            Assert.AreEqual(4, Bagel.BagelPrice(4));
        }
    }
}