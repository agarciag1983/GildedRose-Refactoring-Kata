namespace GildedRoseKata.Entities
{
    public sealed class ProxyItem
    {
        private readonly Item item;

        public ProxyItem(Item item)
        {
            this.item = item;
        }

        #region " Item Set Property Methods "

        public void CleanQuality()
        {
            item.Quality = 0;
        }

        public void DecreaseSellIn()
        {
            item.SellIn--;
        }

        public void DecreaseQuality()
        {
            if (item.Quality > 0)
            {
                item.Quality--;
            }
        }

        public void IncreaseQuality(int maxQuality)
        {
            if (item.Quality < maxQuality)
            {
                item.Quality++;
            }
        }

        #endregion

        #region " Item Share Property Methods "
        public int SellIn => item.SellIn;
        public int Quality => item.Quality;

        #endregion
    }
}
