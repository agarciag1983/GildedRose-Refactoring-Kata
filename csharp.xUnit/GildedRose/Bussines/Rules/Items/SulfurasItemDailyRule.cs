using GildedRoseKata.Entities;

namespace GildedRoseKata.Bussines.Rules.Items
{
    internal sealed class SulfurasItemDailyRule : BaseItemDailyRule
    {
        public SulfurasItemDailyRule(Item item) : base(item)
        { }

        public override void ApplyRule()
        {
            // Sulfuras never has to be sold or decreases in Quality
        }
    }
}
