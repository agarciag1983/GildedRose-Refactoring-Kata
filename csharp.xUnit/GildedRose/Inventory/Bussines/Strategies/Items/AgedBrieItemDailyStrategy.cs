using GildedRoseKata.Inventory.Entities;

namespace GildedRoseKata.Inventory.Bussines.Strategies.Items
{
    internal sealed class AgedBrieItemDailyStrategy : BaseItemDailyStrategy
    {
        public AgedBrieItemDailyStrategy(ItemProxy itemProxy) : base(itemProxy)
        { }

        public override void Apply()
        {
            if (IsQuantityLessThanMaxQuality)
            {
                IncreaseQuality();
            }

            DecreaseSellIn();

            if (IsSellInHasPassed && IsQuantityLessThanMaxQuality)
            {
                IncreaseQuality();
            }
        }
    }
}
