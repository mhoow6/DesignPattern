using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_TemplateMethod
{
    class KaKaoMapView : MapView
    {
        protected override void ConnectMapServer()
        {
            Console.WriteLine("카카오 지도 서버에 연결");
        }

        protected override void MoveToCurrentLocation()
        {
            Console.WriteLine("카카오 지도를 보여줌");
        }

        protected override void ShowMapOnScreen()
        {
            Console.WriteLine("카카오 지도에서 현 좌표로 이동");
        }
    }
}
