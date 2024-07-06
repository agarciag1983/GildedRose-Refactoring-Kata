using GildedRoseKata.Entities;

namespace GildedRoseKata.Bussines.Rules.Items
{
    internal abstract class BaseItemDailyRule : IRule
    {
        protected readonly int maxQuality = 50;
        protected ProxyItem Item { get; }

        protected bool IsSellInHasPassed => Item.SellIn < 0;

        protected bool IsQuantityLessThanMaxQuality => Item.Quality < maxQuality;
        
        public BaseItemDailyRule(Item item)
        {
            Item = new (item);
        }

        protected void IncreaseQuality() => Item.IncreaseQuality(maxQuality);
        protected void CleanQuality() => Item.CleanQuality();
        protected void DecreaseQuality() => Item.DecreaseQuality();
        protected void DecreaseSellIn() => Item.DecreaseSellIn();

        public abstract void Apply();
    }
}
