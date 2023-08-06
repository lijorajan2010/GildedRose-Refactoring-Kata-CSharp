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
    public class ConjuredUpdateStrategyTests
    {
        [TestMethod]
        public void ConjuredUpdateStrategyTests_UpdateItem_ShouldDecreaseQualityBy2_WhenSellInIsPositive()
        {
            // Arrange
            var strategy = new ConjuredUpdateStrategy();
            var item = new Item { Name = "Conjured Mana Cake", SellIn = 5, Quality = 20 };

            // Act
            strategy.UpdateItem(item);

            // Assert
            Assert.AreEqual(4, item.SellIn);
            Assert.AreEqual(18, item.Quality);
        }

        [TestMethod]
        public void ConjuredUpdateStrategyTests_UpdateItem_ShouldNotDecreaseQualityBelowZero()
        {
            // Arrange
            var strategy = new ConjuredUpdateStrategy();
            var item = new Item { Name = "Conjured Mana Cake", SellIn = 5, Quality = 1 };

            // Act
            strategy.UpdateItem(item);

            // Assert
            Assert.AreEqual(4, item.SellIn);
            Assert.AreEqual(0, item.Quality);
        }
    }
}
