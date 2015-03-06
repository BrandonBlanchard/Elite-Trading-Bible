using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.TradingBible.Data;
using Assets.TradingBible.Factories;
using Assets.TradingBible.Models;
using Assets.TradingBible.Interfaces;
using Assets.TradingBible.States.Ui;
using System;

namespace Assets.TradingBible
{
    public class TradingBible : MonoBehaviour
    {
        public CommodityService _commodities { get; protected set; }

        public CultureFactory _cultureFactory { get; protected set; }

        public CommodityFactory _commodityFactory { get; protected set; }

        public GameObject Canvas;

        public GameObject CurrentCard { get; protected set; }

        public IMenuState State { get; protected set; }

        public void Start()
        {
            _commodities = new CommodityService();
            _commodityFactory = new CommodityFactory();
            _cultureFactory = new CultureFactory(_commodityFactory);

            State = new ShowCultureState(this, Canvas);
        }

        public void Update()
        {
            if (Input.anyKeyDown)
            {
                State.HandleInput();
            }

            State.Update();

        }

        public void UpdateState(IMenuState state)
        {
            State = state;
        }
    }
}
