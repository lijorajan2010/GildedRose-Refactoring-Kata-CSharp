using GildedRose_CSharp.Domain.Entities;
using GildedRose_CSharp.Domain.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose_CSharp.Tests
{
    [TestClass]
    public class LegendaryItemsUpdateStratgeyTests
    {
        [TestMethod]
        public void LegendaryItemsUpdateStratgeyTests_UpdateItem_ShouldNotChangeSellInAndQuality()
        {
            // Arrange
            var strategy = new LegendaryItemsUpdateStratgey();
            var item = new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 10, Quality = 80 };

            // Act
            strategy.UpdateItem(item);

            // Assert
            Assert.AreEqual(10, item.SellIn);
            Assert.AreEqual(80, item.Quality);
        }
    }
}
