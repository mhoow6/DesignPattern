using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_Mediator
{
    class ModeSwitch
    {
        Mode mode = Mode.LIST;

        ModeMediator modeMediator;

        public void SetModeMediator(ModeMediator _modeMediator)
        {
            modeMediator = _modeMediator;
        }

        public void ToggleMode()
        {
            mode = mode == Mode.LIST ? Mode.GALLERY : Mode.LIST;

            if (modeMediator != null)
            {
                modeMediator.OnModeChange(mode);
            }
        }
    }
}
