using GildedRoseKata.Inventory.Entities;

namespace GildedRoseKata.Inventory.Bussines.Strategies.Items
{
    /// <summary>
    /// Define the daily strategy for the normal item.
    /// </summary>
    internal sealed class NormalItemDailyStrategy : BaseItemDailyStrategy
    {
        public NormalItemDailyStrategy(ItemProxy itemProxy) : base(itemProxy)
        { }

        public override void Apply()
        {
            // Decrease quality by one when the day ends.
            DecreaseQuality();

            // Decrease sellIn by one when the day ends.
            DecreaseSellIn();

            // Decrease quality by one when the sellIn has passed.
            if (IsSellInHasPassed)
            {
                DecreaseQuality();
            }
        }
    }
}
