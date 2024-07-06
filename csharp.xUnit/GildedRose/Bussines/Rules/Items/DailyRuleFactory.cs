using GildedRoseKata.Entities;

namespace GildedRoseKata.Bussines.Rules.Items
{
    internal static class DailyRuleFactory
    {
        public static IRule Create(Item item)
        {
            return item.Name switch
            {
                ItemNames.AgedBrie => new AgedBrieItemDailyRule(item),
                ItemNames.BackstagePasses => new BackstageItemDailyRule(item),
                ItemNames.Sulfuras => new SulfurasItemDailyRule(item),
                ItemNames.Conjured => new ConjuredItemDailyRule(item),
                _ => new NormalItemDailyRule(item)
            };
        }
    }
}
