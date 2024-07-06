using GildedRoseKata.Entities;
using System.Collections.Generic;

namespace GildedRoseKata.Data.Moq
{
    internal static class ItemCollectionMoq
    {
        public static IList<Item> GetCollection()
        {
            return new List<Item>
            {
                new Item {
                    Name = "+5 Dexterity Vest",
                    SellIn = 10,
                    Quality = 20
                },
                new Item {
                    Name = ItemNames.AgedBrie,
                    SellIn = 2,
                    Quality = 0
                },
                new Item {
                    Name = "Elixir of the Mongoose",
                    SellIn = 5,
                    Quality = 7
                },
                new Item {
                    Name = ItemNames.Sulfuras,
                    SellIn = 0,
                    Quality = 80
                },
                new Item {
                    Name = ItemNames.Sulfuras,
                    SellIn = -1,
                    Quality = 80
                },
                new Item
                {
                    Name = ItemNames.BackstagePasses,
                    SellIn = 15,
                    Quality = 20
                },
                new Item
                {
                    Name = ItemNames.BackstagePasses,
                    SellIn = 10,
                    Quality = 49
                },
                new Item
                {
                    Name = ItemNames.BackstagePasses,
                    SellIn = 5,
                    Quality = 49
                },
                // this conjured item does not work properly yet
                new Item {
                    Name = ItemNames.Conjured,
                    SellIn = 3,
                    Quality = 6
                }

            };
        }
    }
}
