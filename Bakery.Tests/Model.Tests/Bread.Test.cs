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
    }
}