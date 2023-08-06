using GildedRose_CSharp.Domain.Entities;
using GildedRose_CSharp.Domain.Factory;
using GildedRose_CSharp.Domain.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose_CSharp.Tests
{
    [TestClass]
    public class UpdateItemStrategyFactoryTests
    {
        [TestMethod]
        public void UpdateItemStrategyFactoryTests_Create_ShouldThrowArgumentNullException_WhenItemIsNull()
        {
            // Arrange
            var factory = new UpdateItemStrategyFactory();

            // Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => factory.Create(null));
        }

        [TestMethod]
        public void UpdateItemStrategyFactoryTests_Create_ShouldReturnCorrectStrategy_ForDifferentItemNames()
        {
            // Arrange
            var factory = new UpdateItemStrategyFactory();
            var agedBrieItem = new Item { Name = "Aged Brie" };
            var backstagePassesItem = new Item { Name = "Backstage passes to a TAFKAL80ETC concert" };
            var sulfurasItem = new Item { Name = "Sulfuras, Hand of Ragnaros" };
            var conjuredItem = new Item { Name = "Conjured Mana Cake" };
            var standardItem = new Item { Name = "Regular Item" };

            // Act
            var agedBrieStrategy = factory.Create(agedBrieItem);
            var backstagePassesStrategy = factory.Create(backstagePassesItem);
            var sulfurasStrategy = factory.Create(sulfurasItem);
            var conjuredStrategy = factory.Create(conjuredItem);
            var standardStrategy = factory.Create(standardItem);

            // Assert
            Assert.IsInstanceOfType(agedBrieStrategy, typeof(AgedBrieUpdateStrategy));
            Assert.IsInstanceOfType(backstagePassesStrategy, typeof(BackStagePassesUpdateStrategy));
            Assert.IsInstanceOfType(sulfurasStrategy, typeof(LegendaryItemsUpdateStratgey));
            Assert.IsInstanceOfType(conjuredStrategy, typeof(ConjuredUpdateStrategy));
            Assert.IsInstanceOfType(standardStrategy, typeof(StandardItemsUpdateStrategy));
        }
    }
}
