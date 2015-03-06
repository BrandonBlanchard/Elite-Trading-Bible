using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.TradingBible.Behaviors
{
    public class UiBehavior : MonoBehaviour
    {
        protected Vector3 from;

        protected Vector3 to;

        protected enum UiAnimation
        {
            slideIn, // Slide down and in, fade in
            slideOut // Slide down and out, fade out
        }

        protected enum StringAnimation
        { 
            charByChar,
        }

        public UiBehavior()
        {

        }

        protected void Animate(Vector3 start, Vector3 end, UiAnimation anim) 
        {
            switch(anim)
            {
                case UiAnimation.slideIn:
                    SlideIn(start, end);
                    break;
            }
        }

        protected void SlideIn(Vector3 start, Vector3 end)
        {
            throw new NotImplementedException();
        }
    }
}
