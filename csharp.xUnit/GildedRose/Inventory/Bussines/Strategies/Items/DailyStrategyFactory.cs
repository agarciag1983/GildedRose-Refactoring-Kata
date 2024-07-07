using GildedRoseKata.Inventory.Bussines.Strategy;
using GildedRoseKata.Inventory.Constants;
using GildedRoseKata.Inventory.Entities;

namespace GildedRoseKata.Inventory.Bussines.Strategies.Items
{
    /// <summary>
    /// Define the daily strategy factory for the items.
    /// </summary>
    internal static class DailyStrategyFactory
    {
        public static IStrategy Create(Item item)
        {
            // Create a proxy for the item.
            var proxy = new ItemProxy(item);

            // Return the strategy based on the item name.
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
