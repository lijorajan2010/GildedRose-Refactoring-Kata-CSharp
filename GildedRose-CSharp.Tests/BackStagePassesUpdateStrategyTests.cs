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
    public class BackStagePassesUpdateStrategyTests
    {
        [TestMethod]
        public void BackStagePassesUpdateStrategyTests_UpdateItem_ShouldIncreaseQualityBy1_WhenSellInIsGreaterThan10()
        {
            // Arrange
            var strategy = new BackStagePassesUpdateStrategy();
            var item = new Item { Name = "Backstage passes", SellIn = 12, Quality = 20 };

            // Act
            strategy.UpdateItem(item);

            // Assert
            Assert.AreEqual(11, item.SellIn);
            Assert.AreEqual(21, item.Quality);
        }

        [TestMethod]
        public void BackStagePassesUpdateStrategyTests_UpdateItem_ShouldIncreaseQualityBy2_WhenSellInIs10OrLess()
        {
            // Arrange
            var strategy = new BackStagePassesUpdateStrategy();
            var item = new Item { Name = "Backstage passes", SellIn = 10, Quality = 30 };

            // Act
            strategy.UpdateItem(item);

            // Assert
            Assert.AreEqual(9, item.SellIn);
            Assert.AreEqual(32, item.Quality);
        }

        [TestMethod]
        public void BackStagePassesUpdateStrategyTests_UpdateItem_ShouldIncreaseQualityBy3_WhenSellInIs5OrLess()
        {
            // Arrange
            var strategy = new BackStagePassesUpdateStrategy();
            var item = new Item { Name = "Backstage passes", SellIn = 5, Quality = 40 };

            // Act
            strategy.UpdateItem(item);

            // Assert
            Assert.AreEqual(4, item.SellIn);
            Assert.AreEqual(43, item.Quality);
        }

        [TestMethod]
        public void BackStagePassesUpdateStrategyTests_UpdateItem_ShouldSetQualityToZero_WhenSellInIsNegative()
        {
            // Arrange
            var strategy = new BackStagePassesUpdateStrategy();
            var item = new Item { Name = "Backstage passes", SellIn = -1, Quality = 50 };

            // Act
            strategy.UpdateItem(item);

            // Assert
            Assert.AreEqual(-2, item.SellIn);
            Assert.AreEqual(0, item.Quality);
        }
    }
}
