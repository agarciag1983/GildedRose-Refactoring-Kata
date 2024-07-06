using GildedRoseKata.Entities;

namespace GildedRoseKata.Bussines.Rules.Items
{
    internal sealed class NormalItemDailyRule : BaseItemDailyRule
    {
        public NormalItemDailyRule(Item item) : base(item)
        { }

        public override void Apply()
        {
            DecreaseQuality();

            DecreaseSellIn();

            if(IsSellInHasPassed)
            {
                DecreaseQuality();
            }
        }
    }
}
