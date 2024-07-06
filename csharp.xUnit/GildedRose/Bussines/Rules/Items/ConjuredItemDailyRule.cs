using GildedRoseKata.Entities;

namespace GildedRoseKata.Bussines.Rules.Items
{
    internal sealed class ConjuredItemDailyRule : BaseItemDailyRule
    {
        public ConjuredItemDailyRule(Item item) : base(item)
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
