using System.Collections;
using System.Collections.Generic;
using Assets.TradingBible;

namespace Assets.TradingBible.Models
{
    public class CommodityModel 
    {
        private string name;

        public categoryType Category { get; private set; }

        public string Name
        {
            get
            {
                if (string.IsNullOrEmpty(name))
                {
                    return Type.ToString();
                }

                return name;
            }
        }

        public commodityType Type { get; private set; }

        public CommodityModel( categoryType cat, commodityType type )
        {
            Category = cat;
            Type = type;
        }

        public void UpdateName(string newName)
        {
            name = newName;
        }

    }
}
