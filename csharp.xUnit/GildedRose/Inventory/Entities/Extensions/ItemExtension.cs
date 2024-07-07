namespace GildedRoseKata.Inventory.Entities.Extensions
{
    /// <summary>
    /// Define the extension methods for the Item class. 
    /// Give the ability to clean, decrease and increase the quality of the item.
    /// </summary>
    public static class ItemExtension
    {
        #region " Item Set Property Methods "

        /// <summary>
        /// Clean the quality of the item.
        /// </summary>
        public static void CleanQuality(this Item scope)
        {
            scope.Quality = 0;
        }

        /// <summary>
        /// Decrease the sellIn of the item.
        /// </summary>
        public static void DecreaseSellIn(this Item scope)
        {
            scope.SellIn--;
        }

        /// <summary>
        /// Decrease the quality of the item.
        /// </summary>
        public static void DecreaseQuality(this Item scope)
        {
            if (scope.Quality > 0)
            {
                scope.Quality--;
            }
        }

        /// <summary>
        /// Increase the quality of the item.
        /// </summary>
        public static void IncreaseQuality(this Item scope, int maxQuality)
        {
            if (scope.Quality < maxQuality)
            {
                scope.Quality++;
            }
        }

        #endregion
    }
}
