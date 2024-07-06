using GildedRoseKata.Entities;

namespace GildedRoseKata.Bussines.Rules.Items
{
    internal abstract class BaseItemDailyRule : IRule
    {
        protected readonly int maxQuality = 50;
        private readonly Item item;

        public BaseItemDailyRule(Item item)
        {
            this.item = item;
        }

        protected bool IsSellInHasPassed => item.SellIn < 0;

        protected int SellIn => item.SellIn;
        protected int Quality => item.Quality;

        protected bool IsQuantityLessThanMaxQuality => item.Quality < maxQuality;

        protected void CleanQuality()
        {
            item.Quality = 0;
        }

        protected void DecreaseSellIn()
        {
            item.SellIn--;
        }

        protected void DecreaseQuality()
        {
            if (item.Quality > 0)
            {
                item.Quality--;
            }
        }

        protected void IncreaseQuality()
        {
            if (item.Quality < maxQuality)
            {
                item.Quality++;
            }
        }

        public abstract void ApplyRule();
    }
}
