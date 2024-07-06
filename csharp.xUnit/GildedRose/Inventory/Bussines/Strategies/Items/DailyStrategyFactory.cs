using GildedRoseKata.Inventory.Bussines.Strategy;
using GildedRoseKata.Inventory.Constants;
using GildedRoseKata.Inventory.Entities;

namespace GildedRoseKata.Inventory.Bussines.Strategies.Items
{
    internal static class DailyStrategyFactory
    {
        public static IStrategy Create(Item item)
        {
            return item.Name switch
            {
                ItemNames.AgedBrie => new AgedBrieItemDailyStrategy(item),
                ItemNames.BackstagePasses => new BackstageItemDailyStrategy(item),
                ItemNames.Sulfuras => new SulfurasItemDailyStrategy(item),
                ItemNames.Conjured => new ConjuredItemDailyStrategy(item),
                _ => new NormalItemDailyStrategy(item)
            };
        }
    }
}
