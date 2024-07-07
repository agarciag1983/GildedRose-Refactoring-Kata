using GildedRoseKata.Inventory.Entities;

namespace GildedRoseKata.Inventory.Bussines.Strategies.Items
{
    /// <summary>
    /// Define the daily strategy for the Conjured item.
    /// </summary>
    internal sealed class ConjuredItemDailyStrategy : BaseItemDailyStrategy
    {
        public ConjuredItemDailyStrategy(ItemProxy itemProxy) : base(itemProxy)
        { }

        public override void Apply()
        {
            // Decrease quality by two when the day ends.
            DecreaseQuality();
            DecreaseQuality();

            // Decrease sellIn by one when the day ends.
            DecreaseSellIn();

            // Decrease quality by two when the sellIn has passed.
            if (IsSellInHasPassed)
            {
                DecreaseQuality();
                DecreaseQuality();
            }
        }
    }
}
