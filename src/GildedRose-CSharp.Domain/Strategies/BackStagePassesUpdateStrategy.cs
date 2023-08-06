using GildedRose_CSharp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose_CSharp.Domain.Strategies
{
    public class BackStagePassesUpdateStrategy : IStockItemUpdateStrategy
    {
        public void UpdateItem(Item item)
        {
            item.SellIn--;
            if (item.SellIn > 10)
            {
                if (item.Quality < 50) item.Quality++;
            }
            else if (item.SellIn < 0)
            {
                item.Quality = 0;
            }
            else if (item.SellIn <= 5)
            {
                if (item.Quality < 50)
                {
                    if (item.Quality + 3 <= 50)
                        item.Quality = item.Quality + 3;
                }
            }
            else if (item.SellIn <= 10)
            {
                if (item.Quality < 50)
                {
                    if (item.Quality + 2 <= 50)
                        item.Quality = item.Quality + 2;
                }
            }
        }
    }
}