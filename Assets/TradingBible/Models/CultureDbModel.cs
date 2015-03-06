using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.TradingBible.Models
{
    public class CultureDbModel
    {
        public cultureType Type { get; private set; }

        public EconomicRelationship Relationship { get; private set; }

        public commodityType Commodity { get; private set; }

        public CultureDbModel(cultureType type, EconomicRelationship relationship, commodityType commodity)
        {
            Type = type;
            Relationship = relationship;
            Commodity = commodity;
        }
    }
}
