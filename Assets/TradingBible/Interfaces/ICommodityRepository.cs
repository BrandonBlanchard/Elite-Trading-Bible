using System;
using System.Collections.Generic;
using Assets.TradingBible;
using Assets.TradingBible.Models;

namespace Assets.TradingBible.Interfaces
{
    public interface ICommodityRepository
    {
        CultureModel GetCommoditiesByCulture (cultureType type);
    }
}
