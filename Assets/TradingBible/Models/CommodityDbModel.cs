using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.TradingBible.Models;

namespace Assets.TradingBible.Models
{
    public class CommodityDbModel
    {        
        public categoryType Category { get; private set; }
        
        public commodityType Type { get; private set; }

        public CommodityDbModel( categoryType cat, commodityType type )
        {
            Category = cat;
            Type = type;
        }
    }
}
