using GildedRose_CSharp.Domain.Entities;
using GildedRose_CSharp.Domain.Factory;

public partial class Program
{
    public static List<Item> Items;
    IUpdateItemStrategyFactory UpdateStrategyFactory { get; set; }
    public Program(IUpdateItemStrategyFactory strategyFactory)
    {
        UpdateStrategyFactory = strategyFactory;
    }

    static void Main()
    {
        Console.WriteLine("OMGHAI!");

        var app = new Program(new UpdateItemStrategyFactory());
        {
            Items = GetDefaultInventory();
        };

        for (var i = 0; i < 31; i++)
        {
            Console.WriteLine("-------- day " + i + " --------");
            Console.WriteLine("name, sellIn, quality");
            for (var j = 0; j < Items.Count; j++)
            {
                System.Console.WriteLine(Items[j]);
            }
            Console.WriteLine("");
            app.UpdateQuality();
        }
    }


    private static List<Item> GetDefaultInventory()
    {
        return new List<Item>
                {
                    new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                    new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                    new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                    new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                    new Item
                        {
                            Name = "Backstage passes to a TAFKAL80ETC concert",
                            SellIn = 15,
                            Quality = 20
                        },
                    new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
                };

    }

    public void UpdateQuality()
    {
        foreach (var item in Items)
        {
            // System.Console.WriteLine(item.Name + " : " + item.Quality.ToString());
            var strategy = UpdateStrategyFactory.Create(item);
            strategy.UpdateItem(item);
        }
    }
}

