using GildedRoseKata.Entities;

namespace GildedRoseKata.Bussines.Rules.Items
{
    internal sealed class AgedBrieItemDailyRule : BaseItemDailyRule
    {
        public AgedBrieItemDailyRule(Item item) : base(item)
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
