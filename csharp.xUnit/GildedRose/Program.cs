using GildedRoseKata.Data.Moq;
using System;
using System.Linq;

namespace GildedRoseKata;

public class Program
{
    private static int minDays = 2;

    private static int GetDays(string[] args)
    {
        var argsDays = args.FirstOrDefault();
        return argsDays is not null && int.TryParse(argsDays, out int days)
            ? days : minDays;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("OMGHAI!");

        var items = ItemCollectionMoq.GetCollection();
        var app = new GildedRose(items);

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