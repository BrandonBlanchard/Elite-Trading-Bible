using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.TradingBible.Data.Repositories;
using Assets.TradingBible.Models;

namespace Assets.TradingBible.Data
{
    public class CommodityService
    {
        public CommodityRepository _commodities = new CommodityRepository();

        public CultureModel GetCultureCard(cultureType type)
        {
            return _commodities.GetCommoditiesByCulture(type);
        }

    }
}
