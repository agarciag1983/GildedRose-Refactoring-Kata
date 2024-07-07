using GildedRoseKata.Inventory.Entities;

namespace GildedRoseKata.Inventory.Bussines.Strategies.Items
{
    /// <summary>
    /// Define the daily strategy for the Aged Brie item.
    /// </summary>
    internal sealed class AgedBrieItemDailyStrategy : BaseItemDailyStrategy
    {
        public AgedBrieItemDailyStrategy(ItemProxy itemProxy) : base(itemProxy)
        { }

        public override void Apply()
        {
            // Increase quality by one when the day ends.
            if (IsQuantityLessThanMaxQuality)
            {
                IncreaseQuality();
            }

            // Decrease sellIn by one when the day ends.
            DecreaseSellIn();

            // Increase quality by one when the sellIn has passed and the queality is less than 50.
            if (IsSellInHasPassed && IsQuantityLessThanMaxQuality)
            {
                IncreaseQuality();
            }
        }
    }
}
