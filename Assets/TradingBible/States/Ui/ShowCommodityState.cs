using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.TradingBible.Interfaces;

namespace Assets.TradingBible.States.Ui
{
    public class ShowCommodityState : IMenuState
    {
        protected Object Bible;

        public ShowCommodityState(Object tradingBible)
        {
            Bible = tradingBible;
        }

        public void Update()
        {

        }

        public void HandleInput ()
        {

        }
    }
}
