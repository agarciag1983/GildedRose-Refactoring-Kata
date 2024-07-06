using GildedRoseKata.Inventory.Constants;
using GildedRoseKata.Inventory.Entities;
using System.Collections.Generic;

namespace GildedRoseKata.Data.Moq
{
    internal static class ItemCollectionMoq
    {
        public static IList<Item> GetCollection()
        {
            return
            [
                new() 
                {
                    Name = "+5 Dexterity Vest",
                    SellIn = 10,
                    Quality = 20
                },
                new() 
                {
                    Name = ItemNames.AgedBrie,
                    SellIn = 2,
                    Quality = 0
                },
                new() 
                {
                    Name = "Elixir of the Mongoose",
                    SellIn = 5,
                    Quality = 7
                },
                new() 
                {
                    Name = ItemNames.Sulfuras,
                    SellIn = 0,
                    Quality = 80
                },
                new() 
                {
                    Name = ItemNames.Sulfuras,
                    SellIn = -1,
                    Quality = 80
                },
                new()
                {
                    Name = ItemNames.BackstagePasses,
                    SellIn = 15,
                    Quality = 20
                },
                new()
                {
                    Name = ItemNames.BackstagePasses,
                    SellIn = 10,
                    Quality = 49
                },
                new()
                {
                    Name = ItemNames.BackstagePasses,
                    SellIn = 5,
                    Quality = 49
                },
                // this conjured item does not work properly yet
                new()
                {
                    Name = ItemNames.Conjured,
                    SellIn = 3,
                    Quality = 6
                }
            ];
        }
    }
}
