namespace GildedRoseKata.Entities.Extensions
{
    public static class ItemExtension
    {
        #region " Item Set Property Methods "

        public static void CleanQuality(this Item scope)
        {
            scope.Quality = 0;
        }

        public static void DecreaseSellIn(this Item scope)
        {
            scope.SellIn--;
        }

        public static void DecreaseQuality(this Item scope)
        {
            if (scope.Quality > 0)
            {
                scope.Quality--;
            }
        }

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
