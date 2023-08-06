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
    public class StandardItemsUpdateStrategyTests
    {
        [TestMethod]
        public void StandardItemsUpdateStrategyTests_UpdateItem_ShouldDecreaseSellInAndQualityBy1_WhenSellInIsPositive()
        {
            // Arrange
            var strategy = new StandardItemsUpdateStrategy();
            var item = new Item { Name = "Regular Item", SellIn = 5, Quality = 10 };

            // Act
            strategy.UpdateItem(item);

            // Assert
            Assert.AreEqual(4, item.SellIn);
            Assert.AreEqual(9, item.Quality);
        }

        [TestMethod]
        public void StandardItemsUpdateStrategyTests_UpdateItem_ShouldDecreaseQualityBy2_WhenSellInIsNegativeOrZero()
        {
            // Arrange
            var strategy = new StandardItemsUpdateStrategy();
            var item1 = new Item { Name = "Regular Item", SellIn = 0, Quality = 10 };
            var item2 = new Item { Name = "Regular Item", SellIn = -1, Quality = 10 };

            // Act
            strategy.UpdateItem(item1);
            strategy.UpdateItem(item2);

            // Assert
            Assert.AreEqual(-1, item1.SellIn);
            Assert.AreEqual(8, item1.Quality);

            Assert.AreEqual(-2, item2.SellIn);
            Assert.AreEqual(8, item2.Quality);
        }

        [TestMethod]
        public void StandardItemsUpdateStrategyTests_UpdateItem_ShouldNotDecreaseQualityBelowZero()
        {
            // Arrange
            var strategy = new StandardItemsUpdateStrategy();
            var item = new Item { Name = "Regular Item", SellIn = 5, Quality = 0 };

            // Act
            strategy.UpdateItem(item);

            // Assert
            Assert.AreEqual(4, item.SellIn);
            Assert.AreEqual(0, item.Quality);
        }
    }
}
