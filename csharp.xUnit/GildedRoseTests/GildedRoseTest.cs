using GildedRoseKata;
using GildedRoseKata.Inventory.Entities;
using System;
using System.Linq.Expressions;
using Xunit;

namespace GildedRoseTests;

public partial class GildedRoseTest
{
    #region " Common Update Quality Test Methods "

    /// <summary>
    /// Check item property value after UpdateQuality method calls.
    /// </summary>
    private void Assert_Item_Property(
        Item item,
        int expectedPropertyValue,
        Expression<Func<Item, int>> evaluatePropertyExpression
    )
    {
        // Arrange
        var gildedRose = new GildedRose(new[] { item });

        // Act
        gildedRose.UpdateQuality();
        var currentPropertyValue = evaluatePropertyExpression.Compile()(item);

        // Assert
        Assert.Equal(
            expectedPropertyValue,
            currentPropertyValue
        );
    }

    private void Assert_Item_SellIn(
        Item item,
        int expectedSellIn
    )
    => Assert_Item_Property(
        item,
        expectedSellIn,
        item => item.SellIn
    );

    private void Assert_Item_Quality(
        Item item,
        int expectedQuality
    )
    => Assert_Item_Property(
        item,
        expectedQuality,
        item => item.Quality
    );


    #endregion

    #region " Random Item Test Methods "

    /// <summary>
    /// Generates a random item with the given quality and sellIn values.
    /// </summary>
    private Item GetRandomItem(
        int quality,
        int sellIn
    )
    {
        var randomName = Guid.NewGuid().ToString();
        return new Item
        {
            Name = randomName,
            SellIn = sellIn,
            Quality = quality
        };
    }

    /// <summary>
    /// Check if the sellIn value decreases by one when the day ends.
    /// </summary>
    [Theory]
    [InlineData(20, 10)]
    [InlineData(20, 0)]
    [InlineData(20, -1)]
    public void UpdateQuality_OnRandomItem_Should_DecreaseSellInByOne_WhenDayEnds(
        int quality,
        int sellIn
    )
    {
        // Arrange
        var randomItem = GetRandomItem(
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
    public void UpdateQuality_OnRandomItem_Should_DecreaseQualityByOne_WhenSellInGreaterThanZero(
        int quality,
        int sellIn
    )
    {
        // Arrange
        var randomItem = GetRandomItem(
            quality,
            sellIn
        );

        // Act

        // Assert
        Assert_Item_Quality(
            randomItem,
            quality - 1
        );
    }

    /// <summary>
    /// Check if the quality value decreases by two when the sellIn value is less than zero.
    /// </summary>
    [Theory]
    [InlineData(20, 0)]
    [InlineData(30, -1)]
    [InlineData(40, -2)]
    public void UpdateQuality_OnRandomItem_Should_DecreaseQualityByTwo_WhenSellInIsEqualOrLessThanZero(
        int quality,
        int sellIn
    )
    {
        // Arrange
        var randomItem = GetRandomItem(
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
    /// Check if the quality value does not decrease below 0.
    /// </summary>
    [Theory]
    [InlineData(0, 5)]
    [InlineData(0, 0)]
    [InlineData(0, -1)]
    public void UpdateQuality_OnRandomItem_Should_DoesNotDecreaseQuality_WhenQualityIsZero(
        int quality,
        int sellIn
    )
    {
        // Arrange
        var randomItem = GetRandomItem(
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