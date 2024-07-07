using GildedRoseKata.Inventory.Entities;

namespace GildedRoseKata.Inventory.Bussines.Strategies.Items
{
    /// <summary>
    /// Define the daily strategy for the Backstage item.
    /// </summary>
    internal sealed class BackstageItemDailyStrategy : BaseItemDailyStrategy
    {
        public BackstageItemDailyStrategy(ItemProxy itemProxy) : base(itemProxy)
        { }

        public override void Apply()
        {
            // Increase quality by one when the day ends.
            if (IsQuantityLessThanMaxQuality)
            {
                IncreaseQuality();
            }

            // Increase quality by one when the sellIn is less than 11 and the queality is less than 50.
            if (Item.SellIn < 11 && IsQuantityLessThanMaxQuality)
            {
                IncreaseQuality();
            }

            // Increase quality by one when the sellIn is less than 6 and the queality is less than 50.
            if (Item.SellIn < 6 && IsQuantityLessThanMaxQuality)
            {
                IncreaseQuality();
            }

            // Decrease sellIn by one when the day ends.
            DecreaseSellIn();

            // Clean quality when the sellIn has passed.
            if (IsSellInHasPassed)
            {
                CleanQuality();
            }
        }
    }
}
