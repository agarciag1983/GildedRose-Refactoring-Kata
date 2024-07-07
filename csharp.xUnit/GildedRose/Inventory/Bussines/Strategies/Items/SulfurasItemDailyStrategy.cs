using GildedRoseKata.Inventory.Entities;

namespace GildedRoseKata.Inventory.Bussines.Strategies.Items
{
    internal sealed class SulfurasItemDailyStrategy : BaseItemDailyStrategy
    {
        public SulfurasItemDailyStrategy(ItemProxy itemProxy) : base(itemProxy)
        { }

        public override void Apply()
        {
            // Sulfuras never has to be sold or decreases in Quality
        }
    }
}
