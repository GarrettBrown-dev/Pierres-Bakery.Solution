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
    }
}