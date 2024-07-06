using GildedRoseKata.Entities.Extensions;

namespace GildedRoseKata.Entities
{
    public sealed class ItemProxy
    {
        private readonly Item item;

        public ItemProxy(Item item)
        {
            this.item = item;
        }

        #region " Item Set Property Methods "

        public void CleanQuality() => item.CleanQuality();

        public void DecreaseSellIn() => item.DecreaseSellIn();

        public void DecreaseQuality() => item.DecreaseQuality();

        public void IncreaseQuality(int maxQuality) => item.IncreaseQuality(maxQuality);

        #endregion

        #region " Item Share Property Methods "
        public int SellIn => item.SellIn;
        public int Quality => item.Quality;

        #endregion
    }
}
