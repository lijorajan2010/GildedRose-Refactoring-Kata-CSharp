using GildedRose_CSharp.Domain.Entities;
using GildedRose_CSharp.Domain.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose_CSharp.Domain.Factory
{
    public interface IUpdateItemStrategyFactory
    {
        IStockItemUpdateStrategy Create(Item item);
    }
}
