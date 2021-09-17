using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_TemplateMethod
{
    abstract class MapView
    {
        protected abstract void ConnectMapServer();
        protected abstract void ShowMapOnScreen();
        protected abstract void MoveToCurrentLocation();

        public void InitMap()
        {
            ConnectMapServer();
            ShowMapOnScreen();
            MoveToCurrentLocation();
        }
    }
}
