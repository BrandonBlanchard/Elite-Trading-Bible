using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.TradingBible.Models
{
    public class CultureModel
    {
        protected string name { get; set; }

        public string Name
        {
            get
            {
                if (!string.IsNullOrEmpty(name))
                {
                    return name;
                }

                return Type.ToString();
            }
        }

        public cultureType Type { get; protected set; }

        public IEnumerable<CommodityModel> Sells { get; protected set; }

        public IEnumerable<CommodityModel> Buys { get; protected set; }


        public CultureModel( cultureType type, IEnumerable<CommodityModel> sells, IEnumerable<CommodityModel> buys )
        {
            name = Helpers.CamelToSpaces(type.ToString());
            Type = type;
            Sells = sells;
            Buys = buys;
        }
    }
}
