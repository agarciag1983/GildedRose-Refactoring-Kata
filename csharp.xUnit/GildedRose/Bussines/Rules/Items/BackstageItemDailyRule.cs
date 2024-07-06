using GildedRoseKata.Entities;

namespace GildedRoseKata.Bussines.Rules.Items
{
    internal sealed class BackstageItemDailyRule : BaseItemDailyRule
    {
        public BackstageItemDailyRule(Item item) : base(item)
        { }

        public override void Apply()
        {
            if (IsQuantityLessThanMaxQuality)
            {
                IncreaseQuality();
            }

            if (Item.SellIn < 11 && IsQuantityLessThanMaxQuality)
            {
                IncreaseQuality();
            }

            if (Item.SellIn < 6 && IsQuantityLessThanMaxQuality)
            {
                IncreaseQuality();
            }

            DecreaseSellIn();

            if (IsSellInHasPassed)
            {
                CleanQuality();
            }
        }
    }
}
