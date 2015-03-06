using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Assets.TradingBible.Data;
using Assets.TradingBible.Interfaces;
using Assets.TradingBible.Models;

namespace Assets.TradingBible.Data.Repositories
{
    public class CommodityRepository : ICommodityRepository
    {

        private FakeDb db = new FakeDb();

        public CultureModel GetCommoditiesByCulture (cultureType type)
        {
            // Need join to get all commodities bought or sold by an industry.
            IEnumerable<CommodityModel> buys = RelationshipsToCommodities(GetCultureRelationships(type, EconomicRelationship.buys));

            IEnumerable<CommodityModel> sells = RelationshipsToCommodities(GetCultureRelationships(type, EconomicRelationship.sells));

            return new CultureModel(type, sells, buys);
        }

        public IEnumerable<CultureDbModel> GetCultureRelationships (cultureType type, EconomicRelationship rel)
        {
           return from c in db.Cultures
                    where c.Type == type
                    && c.Relationship == rel
                    select c;
        }

        public IEnumerable<CommodityModel> RelationshipsToCommodities(IEnumerable<CultureDbModel> cultureRelationships)
        {
            List<CommodityModel> commodities = new List<CommodityModel>();

            CommodityModel model;

            foreach(CultureDbModel cultureRel in cultureRelationships)
            {

                categoryType category = (from c in db.Commodities
                                         where c.Type == cultureRel.Commodity
                                         select c.Category).FirstOrDefault();

                model = new CommodityModel(
                            category,
                            cultureRel.Commodity
                        );

                commodities.Add(model);
            }

            return commodities;
        }
    }
}
