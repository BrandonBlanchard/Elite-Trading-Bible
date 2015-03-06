using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using UnityEngine;
using Assets.TradingBible.Interfaces;
using Assets.TradingBible.States;
using Assets.TradingBible.Models;

namespace Assets.TradingBible.States.Ui
{
    public class ShowCultureState : IMenuState
    {
        protected TradingBible Bible;

        protected GameObject Canvas;

        protected GameObject Graphic;

        protected CultureUIBehavior Behavior;

        protected IDictionary<cultureType, cultureType> Ordering = new Dictionary<cultureType, cultureType>()
        {
            { cultureType.agriculture, cultureType.extraction },
            { cultureType.extraction, cultureType.highTech },
            { cultureType.highTech, cultureType.industrial },
            { cultureType.industrial, cultureType.refinery },
            { cultureType.refinery, cultureType.agriculture}
            
        };

        public ShowCultureState(TradingBible tradingBible, GameObject canvas)
        {
            Bible = tradingBible;
            Canvas = canvas;

            CreateCard(cultureType.highTech);
        }

        public ShowCultureState(TradingBible tradingBible, GameObject canvas, cultureType type, GameObject oldUI)
        {
            Bible = tradingBible;
            Canvas = canvas;
            Debug.Log("Created ShowCultureState");
            CreateCard(type);
            GameObject.Destroy(oldUI);

        }

        public void Update()
        {

        }

        public void HandleInput()
        {
            if(Input.GetKeyDown(KeyCode.LeftArrow))
            {
                CycleNext(false);
            }

            if(Input.GetKeyDown(KeyCode.RightArrow))
            {
                CycleNext(true);
            }

        }

        protected void CycleNext(bool reverseDirection)
        {
            Array types = Enum.GetValues(typeof(cultureType));

            for(var i = 0; i < types.Length; i++)
            {
                cultureType thisType = (cultureType)Enum.Parse(typeof(cultureType), types.GetValue(i).ToString(), true);
                
                if (Behavior.Model.Type == thisType)
                {
                    cultureType newType = GetLoopedType(thisType, reverseDirection);
                    
                    Bible.UpdateState(new ShowCultureState(Bible, Canvas, newType, Graphic));
                }
            }
        }

        protected cultureType GetLoopedType(cultureType key, bool reverseDirection)
        {
            if(reverseDirection)
            {
                return Ordering.FirstOrDefault(x => x.Value == key).Key;
            }

            return Ordering.FirstOrDefault(x => x.Key == key).Value;
        }

        protected void CreateCard(cultureType type)
        {
            CultureModel culture = Bible._commodities.GetCultureCard(type);
            Graphic = Bible._cultureFactory.CreateCultureUi(culture, Canvas);
            Behavior = Graphic.GetComponent<CultureUIBehavior>();
        }

    }
}
