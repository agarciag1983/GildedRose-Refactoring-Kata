using GildedRoseKata.Inventory.Entities.Extensions;

namespace GildedRoseKata.Inventory.Entities
{
    /// <summary>
    /// Define a wrapper for the Item class to avoid exposing the Item class properties.
    /// </summary>
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
