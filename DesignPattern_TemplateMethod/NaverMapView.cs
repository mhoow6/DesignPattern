using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_TemplateMethod
{
    class NaverMapView : MapView
    {
        protected override void ConnectMapServer()
        {
            Console.WriteLine("네이버 지도 서버에 연결");
        }

        protected override void MoveToCurrentLocation()
        {
            Console.WriteLine("네이버 지도를 보여줌");
        }

        protected override void ShowMapOnScreen()
        {
            Console.WriteLine("네이버 지도에서 현 좌표로 이동");
        }
    }
}
