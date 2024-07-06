using GildedRoseKata.Inventory.Entities;

namespace GildedRoseKata.Inventory.Bussines.Strategies.Items
{
    internal sealed class NormalItemDailyStrategy : BaseItemDailyStrategy
    {
        public NormalItemDailyStrategy(Item item) : base(item)
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
