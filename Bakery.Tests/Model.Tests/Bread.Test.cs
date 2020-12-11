using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
    [TestClass]

    public class BreadTest
    {
        [TestMethod]
        public void GetBread_CreatesInstanceOfBread_Bread()
        {
            Bread newBread = new Bread(0, 0);
            Assert.AreEqual(typeof(Bread), newBread.GetType());
        }
        [TestMethod]
        public void SetObject_SetObject_Bread()
        {
            int quant = 0;
            int price = 0;
            Bread newBread = new Bread(quant, price);

            int updatedQuant = 2;
            newBread.Quant = updatedQuant;
            int finalQu = newBread.Quant;
            int updatedPrice = 2;
            newBread.Price = updatedPrice;
            int finalPr = newBread.Price;

            Assert.AreEqual(updatedQuant, finalQu);
            Assert.AreEqual(updatedPrice, finalPr);
        }
        [TestMethod]
        public void BreadPrice_ShowPriceForSingleLoaf_5()
        {
            Assert.AreEqual(5, Bread.BreadPrice(1));
        }
        [TestMethod]
        public void BreadPrice_ShowPriceFor3LoavesOfBread_10()
        {
            Assert.AreEqual(10, Bread.BreadPrice(3));
        }
    }
}