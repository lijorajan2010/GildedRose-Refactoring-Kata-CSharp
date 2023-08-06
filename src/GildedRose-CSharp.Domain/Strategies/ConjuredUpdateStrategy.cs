using GildedRose_CSharp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose_CSharp.Domain.Strategies
{
    public class ConjuredUpdateStrategy : IStockItemUpdateStrategy
    {
        public void UpdateItem(Item item)
        {
            item.Quality -= 2;
            if (item.SellIn > 0)
            {
                item.SellIn--;
            }
            if (item.SellIn <= 0)
                item.Quality -= 2;

            if (item.Quality < 0)
            {
                item.Quality = 0;
            }

        }
    }
}