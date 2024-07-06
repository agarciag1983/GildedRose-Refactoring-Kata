using GildedRoseKata.Inventory.Entities;

namespace GildedRoseKata.Inventory.Bussines.Strategies.Items
{
    internal sealed class BackstageItemDailyStrategy : BaseItemDailyStrategy
    {
        public BackstageItemDailyStrategy(Item item) : base(item)
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
