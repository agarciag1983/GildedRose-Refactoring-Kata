using GildedRoseKata.Inventory.Entities;

namespace GildedRoseKata.Inventory.Bussines.Strategies.Items
{
    /// <summary>
    /// Define the daily strategy for the Sulfuras item.
    /// </summary>
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
