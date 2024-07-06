using GildedRoseKata.Inventory.Bussines.Strategy;
using GildedRoseKata.Inventory.Entities;

namespace GildedRoseKata.Inventory.Bussines.Strategies.Items
{
    internal abstract class BaseItemDailyStrategy : IStrategy
    {
        protected readonly int maxQuality = 50;
        protected ItemProxy Item { get; }

        protected bool IsSellInHasPassed => Item.SellIn < 0;

        protected bool IsQuantityLessThanMaxQuality => Item.Quality < maxQuality;

        public BaseItemDailyStrategy(Item item)
        {
            Item = new(item);
        }

        protected void IncreaseQuality() => Item.IncreaseQuality(maxQuality);
        protected void CleanQuality() => Item.CleanQuality();
        protected void DecreaseQuality() => Item.DecreaseQuality();
        protected void DecreaseSellIn() => Item.DecreaseSellIn();

        public abstract void Apply();
    }
}
