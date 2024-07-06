using GildedRoseKata.Entities;
using Xunit;

namespace GildedRoseTests
{
    public partial class GildedRoseTest
    {
        #region " Sulfuras Item Test Methods "

        /// <summary>
        /// Generates a sulfuras item with the given quality and sellIn values.
        /// </summary>
        private Item GetSulfurasItem(
            int quality,
            int sellIn
        )
        => new Item
        {
            Name = ItemNames.Sulfuras,
            SellIn = sellIn,
            Quality = quality
        };

        /// <summary>
        /// Check if the sellIn value keep equal when the day ends.
        /// </summary>
        [Theory]
        [InlineData(20, 10)]
        [InlineData(20, 0)]
        [InlineData(40, -1)]
        public void UpdateQuality_OnSulfurasItem_Should_KeepSameSellIn_WhenDayEnds(
            int quality,
            int sellIn
        )
        {
            // Arrange
            var randomItem = GetSulfurasItem(
                quality,
                sellIn
            );

            // Act

            // Assert
            Assert_Item_SellIn(
                randomItem,
                sellIn
            );
        }

        /// <summary>
        /// Check if the query value keep equal when the day ends.
        /// </summary>
        [Theory]
        [InlineData(20, 15)]
        [InlineData(20, 11)]
        [InlineData(20, 0)]
        [InlineData(20, -1)]
        public void UpdateQuality_OnSulfurasItem_Should_KeepSameQuality_WhenDayEnds(
            int quality,
            int sellIn
        )
        {
            // Arrange
            var item = GetSulfurasItem(
                quality,
                sellIn
            );

            // Act

            // Assert
            Assert_Item_Quality(
                item,
                quality
            );
        }

        #endregion
    }
}
