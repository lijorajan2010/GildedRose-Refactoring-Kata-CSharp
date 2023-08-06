using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GildedRose_CSharp.Domain.Entities;

namespace GildedRose_CSharp.Domain.Strategies
{
    public interface IStockItemUpdateStrategy
    {
        void UpdateItem(Item item);
    }
}
