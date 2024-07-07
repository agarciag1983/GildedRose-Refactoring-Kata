using GildedRoseKata.Inventory.Entities;

namespace GildedRoseKata.Inventory.Bussines.Strategies.Items
{
    internal sealed class NormalItemDailyStrategy : BaseItemDailyStrategy
    {
        public NormalItemDailyStrategy(ItemProxy itemProxy) : base(itemProxy)
        { }

        public override void Apply()
        {
            DecreaseQuality();

            DecreaseSellIn();

            if (IsSellInHasPassed)
            {
                DecreaseQuality();
            }
        }
    }
}
