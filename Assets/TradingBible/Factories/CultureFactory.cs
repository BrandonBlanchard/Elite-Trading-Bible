using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Assets.TradingBible.Models;

namespace Assets.TradingBible.Factories
{
    public class CultureFactory
    {

        public CommodityFactory _commodityFactory { get; private set; }

        public CultureFactory (CommodityFactory cFactory)
        {
            _commodityFactory = cFactory;
        }

        public GameObject CreateCultureUi( CultureModel model, GameObject container)
        {
            GameObject cultureUiPrefab = GameObject.Instantiate(Resources.Load("Prefabs/culturePrefab", typeof(GameObject))) as GameObject;

            cultureUiPrefab.transform.SetParent(container.transform);

            CultureUIBehavior ui = cultureUiPrefab.GetComponent<CultureUIBehavior>();

            ui.Init(model);

            InitCommoditiesCreation(ui.Model.Buys, ui.BuyContainer);
            InitCommoditiesCreation(ui.Model.Sells, ui.SellContainer);

            return cultureUiPrefab;
        }

        public void InitCommoditiesCreation(IEnumerable<CommodityModel> commodities, GameObject container)
        {
            _commodityFactory.ConstructCommoditiesList(commodities, container);
        }
    }
}
