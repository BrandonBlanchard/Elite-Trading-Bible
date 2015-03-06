using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.TradingBible.Interfaces
{
    public interface IMenuState
    {
        void Update();

        void HandleInput();
    }
}
