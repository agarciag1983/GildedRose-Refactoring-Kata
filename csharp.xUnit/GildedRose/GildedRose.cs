using GildedRoseKata.Inventory.Bussines.Strategies.Items;
using GildedRoseKata.Inventory.Entities;
using System.Collections.Generic;

namespace GildedRoseKata;

public sealed class GildedRose
{
    private readonly IList<Item> Items;

    public GildedRose(IList<Item> Items)
    {
        this.Items = Items;
    }

    public void UpdateQuality()
    {
        foreach (var item in Items)
        {
            var itemRule = DailyStrategyFactory.Create(item);
            itemRule.Apply();
        }
    }
}