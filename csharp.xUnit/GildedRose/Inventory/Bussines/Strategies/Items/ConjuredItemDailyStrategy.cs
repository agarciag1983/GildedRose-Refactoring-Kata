using GildedRoseKata.Inventory.Entities;

namespace GildedRoseKata.Inventory.Bussines.Strategies.Items
{
    internal sealed class ConjuredItemDailyStrategy : BaseItemDailyStrategy
    {
        public ConjuredItemDailyStrategy(Item item) : base(item)
        { }

        public override void Apply()
        {
            DecreaseQuality();
            DecreaseQuality();

            DecreaseSellIn();

            if (IsSellInHasPassed)
            {
                DecreaseQuality();
                DecreaseQuality();
            }
        }
    }
}
