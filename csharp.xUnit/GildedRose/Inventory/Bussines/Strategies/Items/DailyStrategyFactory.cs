using GildedRoseKata.Inventory.Bussines.Strategy;
using GildedRoseKata.Inventory.Constants;
using GildedRoseKata.Inventory.Entities;

namespace GildedRoseKata.Inventory.Bussines.Strategies.Items
{
    internal static class DailyStrategyFactory
    {
        public static IStrategy Create(Item item)
        {
            var proxy = new ItemProxy(item);

            return item.Name switch
            {
                ItemNames.AgedBrie => new AgedBrieItemDailyStrategy(proxy),
                ItemNames.BackstagePasses => new BackstageItemDailyStrategy(proxy),
                ItemNames.Sulfuras => new SulfurasItemDailyStrategy(proxy),
                ItemNames.Conjured => new ConjuredItemDailyStrategy(proxy),
                _ => new NormalItemDailyStrategy(proxy)
            };
        }
    }
}
