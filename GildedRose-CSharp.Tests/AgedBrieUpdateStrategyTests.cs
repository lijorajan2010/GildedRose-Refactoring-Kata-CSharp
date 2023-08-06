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
    public class AgedBrieUpdateStrategyTests
    {
            [TestMethod]
            public void AgedBrieUpdateStrategyTests_UpdateItem_ShouldDecreaseSellInAndIncreaseQuality()
            {
                // Arrange
                var strategy = new AgedBrieUpdateStrategy();
                var item = new Item { Name = "Aged Brie", SellIn = 5, Quality = 10 };

                // Act
                strategy.UpdateItem(item);

                // Assert
                Assert.AreEqual(4, item.SellIn);
                Assert.AreEqual(11, item.Quality);
            }

            [TestMethod]
            public void AgedBrieUpdateStrategyTests_UpdateItem_ShouldNotIncreaseQualityBeyond50()
            {
                // Arrange
                var strategy = new AgedBrieUpdateStrategy();
                var item = new Item { Name = "Aged Brie", SellIn = 5, Quality = 50 };

                // Act
                strategy.UpdateItem(item);

                // Assert
                Assert.AreEqual(4, item.SellIn);
                Assert.AreEqual(50, item.Quality); // Quality should not exceed 50
            }
        }
}
