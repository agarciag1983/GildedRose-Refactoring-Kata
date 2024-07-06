using GildedRoseKata.Entities;
using Xunit;

namespace GildedRoseTests
{
    public partial class GildedRoseTest
    {
        #region " Backstage Item Test Methods "

        /// <summary>
        /// Generates a backstage item with the given quality and sellIn values.
        /// </summary>
        private Item GetBackstageItem(
            int quality,
            int sellIn
        )
        => new Item
        {
            Name = ItemNames.BackstagePasses,
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
        public void UpdateQuality_OnBackstageItem_Should_DecreaseSellInByOne_WhenDayEnds(
            int quality,
            int sellIn
        )
        {
            // Arrange
            var item = GetBackstageItem(
                quality,
                sellIn
            );

            // Act

            // Assert
            Assert_Item_SellIn(
                item,
                sellIn - 1
            );
        }

        /// <summary>
        /// Check if quality value increases by one when the day ends.
        /// </summary>
        [Theory]
        [InlineData(20, 15)]
        [InlineData(20, 11)]
        public void UpdateQuality_OnBackstageItem_Should_IncreaseQualityByOne_WhenSellInIsEqualOrGreaterThanEleven(
            int quality,
            int sellIn
        )
        {
            // Arrange
            var item = GetBackstageItem(
                quality,
                sellIn
            );

            // Act

            // Assert
            Assert_Item_Quality(
                item,
                quality + 1
            );
        }

        /// <summary>
        /// Check if quality value increases by one when the day ends.
        /// </summary>
        [Theory]
        [InlineData(20, 10)]
        [InlineData(20, 8)]
        [InlineData(20, 6)]
        public void UpdateQuality_OnBackstageItem_Should_IncreaseQualityByTwo_WhenSellInIsLessThanElevenAndEqualOrGreaterThanSix(
            int quality,
            int sellIn
        )
        {
            // Arrange
            var item = GetBackstageItem(
                quality,
                sellIn
            );

            // Act

            // Assert
            Assert_Item_Quality(
                item,
                quality + 2
            );
        }

        /// <summary>
        /// Check if quality value increases by one when the day ends.
        /// </summary>
        [Theory]
        [InlineData(20, 5)]
        [InlineData(20, 3)]
        [InlineData(20, 1)]
        public void UpdateQuality_OnBackstageItem_Should_IncreaseQualityByThree_WhenSellInIsLessThanSixAndGreaterThanZero(
            int quality,
            int sellIn
        )
        {
            // Arrange
            var item = GetBackstageItem(
                quality,
                sellIn
            );

            // Act

            // Assert
            Assert_Item_Quality(
                item,
                quality + 3
            );
        }

        /// <summary>
        /// Check if the quality value increases by two when the sellIn value is less than zero.
        /// </summary>
        [Theory]
        [InlineData(20, 0)]
        [InlineData(30, -1)]
        [InlineData(40, -2)]
        public void UpdateQuality_OnBackstageItem_Should_SetQualityToZero_WhenSellInIsEqualOrLessThanZero(
            int quality,
            int sellIn
        )
        {
            // Arrange
            var item = GetBackstageItem(
                quality,
                sellIn
            );

            // Act

            // Assert
            Assert_Item_Quality(
                item,
                0
            );
        }

        #endregion
    }
}
