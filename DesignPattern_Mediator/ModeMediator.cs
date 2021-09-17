using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_Mediator
{
    class ModeMediator
    {
        List<ModeListener> listeners = new List<ModeListener>();

        public void AddListener(ModeListener listener)
        {
            listeners.Add(listener);
        }

        public void OnModeChange(Mode mode)
        {
            foreach (var listener in listeners)
            {
                listener.OnModeChange(mode);
            }
        }
    }
}
