using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_State
{
    public class ModeSwitch
    {
        private ModeState modeState = new ModeStateLight();

        public void SetState(ModeState _modeState)
        {
            modeState = _modeState;
        }

        public void OnSwitch()
        {
            modeState.toggle(this);
        }
    }
}
