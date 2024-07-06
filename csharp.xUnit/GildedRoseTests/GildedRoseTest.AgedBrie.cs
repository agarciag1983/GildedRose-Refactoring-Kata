using GildedRoseKata.Entities;
using Xunit;

namespace GildedRoseTests
{
    public partial class GildedRoseTest
    {
        #region " Aged Brie Item Test Methods "

        /// <summary>
        /// Generates a aged brie item with the given quality and sellIn values.
        /// </summary>
        private Item GetAgedBrieItem(
            int quality,
            int sellIn
        )
        => new Item
        {
            Name = ItemNames.AgedBrie,
            SellIn = sellIn,
            Quality = quality
        };

        /// <summary>
        /// Check if the sellIn value decreases by one when the day ends.
        /// </summary>
        [Theory]
        [InlineData(20, 10)]
        [InlineData(20, 0)]
        [InlineData(40, -1)]
        public void UpdateQuality_OnAgedBrieItem_Should_DecreaseSellInByOne_WhenDayEnds(
            int quality,
            int sellIn
        )
        {
            // Arrange
            var item = GetAgedBrieItem(
                quality,
                sellIn
            );

            // Act

            // Assert
            UpdateQuality_Test_Item_SellIn(
                item,
                sellIn - 1
            );
        }

        /// <summary>
        /// Check if quality value increases by one when the day ends.
        /// </summary>
        [Theory]
        [InlineData(20, 15)]
        [InlineData(20, 9)]
        [InlineData(20, 5)]
        [InlineData(20, 1)]
        public void UpdateQuality_OnAgedBrieItem_Should_IncreaseQualityByOne_WhenSellInGreaterThanZero(
            int quality,
            int sellIn
        )
        {
            // Arrange
            var item = GetAgedBrieItem(
                quality,
                sellIn
            );

            // Act

            // Assert
            UpdateQuality_Test_Item_Quality(
                item,
                quality + 1
            );
        }

        /// <summary>
        /// Check if the quality value increases by two when the sellIn value is less than zero.
        /// </summary>
        [Theory]
        [InlineData(20, 0)]
        [InlineData(30, -1)]
        [InlineData(40, -2)]
        public void UpdateQuality_OnAgedBrieItem_Should_IncreaseQualityByTwo_WhenSellInIsEqualOrLessThanZero(
            int quality,
            int sellIn
        )
        {
            // Arrange
            var item = GetAgedBrieItem(
                quality,
                sellIn
            );

            // Act

            // Assert
            UpdateQuality_Test_Item_Quality(
                item,
                quality + 2
            );
        }

        #endregion
    }
}
