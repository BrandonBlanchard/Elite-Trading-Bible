using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Assets.TradingBible.Models;

namespace Assets.TradingBible.Factories
{
    public class CommodityFactory
    {
        public CommodityFactory()
        {

        }

        public void ConstructCommoditiesList(IEnumerable<CommodityModel> commodities, GameObject container)
        {
            GameObject commodityUiPrefab;
            
            foreach(CommodityModel commodity in commodities.OrderBy(x => x.Name))
            {
                commodityUiPrefab = GameObject.Instantiate(Resources.Load("Prefabs/commodityPrefab", typeof(GameObject))) as GameObject;
              
                commodityUiPrefab.transform.SetParent(container.transform);
                
                CommodityUIBehavior Ui = commodityUiPrefab.GetComponent<CommodityUIBehavior>();

                commodity.UpdateName(Helpers.CamelToSpaces(commodity.Type.ToString()));

                Ui.Init(commodity);
            }
        }
    }
}
