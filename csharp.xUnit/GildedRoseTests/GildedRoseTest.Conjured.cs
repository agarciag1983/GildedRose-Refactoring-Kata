using GildedRoseKata.Entities;
using Xunit;

namespace GildedRoseTests
{
    public partial class GildedRoseTest
    {
        #region " Conjured Test Methods "

        /// <summary>
        /// Generates a conjured item with the given quality and sellIn values.
        /// </summary>
        private Item GetConjuredItem(
            int quality,
            int sellIn
        )
        => new Item
        {
            Name = ItemNames.Conjured,
            SellIn = sellIn,
            Quality = quality
        };

        /// <summary>
        /// Check if the sellIn value decreases by one when the day ends.
        /// </summary>
        [Theory]
        [InlineData(20, 10)]
        [InlineData(20, 0)]
        [InlineData(20, -1)]
        public void UpdateQuality_OnConjuredItem_Should_DecreaseSellInByOne_WhenDayEnds(
            int quality,
            int sellIn
        )
        {
            // Arrange
            var randomItem = GetConjuredItem(
                quality,
                sellIn
            );

            // Act

            // Assert
            Assert_Item_SellIn(
                randomItem,
                sellIn - 1
            );
        }

        /// <summary>
        /// Check if the quality value decreases by one when the day ends. 
        /// </summary>
        [Theory]
        [InlineData(20, 15)]
        [InlineData(20, 9)]
        [InlineData(20, 5)]
        [InlineData(20, 1)]
        public void UpdateQuality_OnConjuredItem_Should_DecreaseQualityByOne_WhenSellInGreaterThanZero(
            int quality,
            int sellIn
        )
        {
            // Arrange
            var randomItem = GetConjuredItem(
                quality,
                sellIn
            );

            // Act

            // Assert
            Assert_Item_Quality(
                randomItem,
                quality - 2
            );
        }

        /// <summary>
        /// Check if the quality value decreases by two when the sellIn value is less than zero.
        /// </summary>
        [Theory]
        [InlineData(20, 0)]
        [InlineData(30, -1)]
        [InlineData(40, -2)]
        public void UpdateQuality_OnConjuredItem_Should_DecreaseQualityByTwo_WhenSellInIsEqualOrLessThanZero(
            int quality,
            int sellIn
        )
        {
            // Arrange
            var randomItem = GetConjuredItem(
                quality,
                sellIn
            );

            // Act

            // Assert
            Assert_Item_Quality(
                randomItem,
                quality - 4
            );
        }

        /// <summary>
        /// Check if the quality value does not decrease below 0.
        /// </summary>
        [Theory]
        [InlineData(0, 5)]
        [InlineData(0, 0)]
        [InlineData(0, -1)]
        public void UpdateQuality_OnConjuredItem_Should_DoesNotDecreaseQuality_WhenQualityIsZero(
            int quality,
            int sellIn
        )
        {
            // Arrange
            var randomItem = GetConjuredItem(
                quality,
                sellIn
            );

            // Act

            // Assert
            Assert_Item_Quality(
                randomItem,
                0
            );
        }

        #endregion
    }
}
