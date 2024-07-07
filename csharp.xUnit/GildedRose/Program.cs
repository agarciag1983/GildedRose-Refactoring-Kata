using GildedRoseKata.Data.Moq;
using System;
using System.Linq;

namespace GildedRoseKata;

public class Program
{
    private static int minDays = 2;

    /// <summary>
    /// Get the days from the args. Otherwise, return the minimum days.
    /// </summary>
    private static int GetDays(string[] args)
    {
        var argsDays = args.FirstOrDefault();
        return argsDays is not null && int.TryParse(argsDays, out int days)
            ? days + 1 : minDays;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("OMGHAI!");

        // Get the items collection.
        var items = ItemCollectionMoq.GetCollection();
        
        // Create the GildedRose app.
        var app = new GildedRose(items);

        // Get the days from the args.
        int days = GetDays(args);

        for (var day = 0; day < days; day++)
        {
            Console.WriteLine("-------- day {0} --------", day);
            Console.WriteLine("name, sellIn, quality");
            foreach (var item in items)
            {
                Console.WriteLine("{0}, {1}, {2}", item.Name, item.SellIn, item.Quality);
            }
            Console.WriteLine("");
            app.UpdateQuality();
        }
    }
}