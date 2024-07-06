using GildedRoseKata.Bussines.Rules.Items;
using GildedRoseKata.Entities;
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
            var itemRule = DailyRuleFactory.Create(item);
            itemRule.Apply();
        }
    }
}