using System;

// 템플릿 메소드 패턴
// - 어떤 같은 형식을 지닌 특정 작업들의 세부작업을 다양하고자 할 때 사용하는 패턴

namespace DesignPattern_TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            new NaverMapView().InitMap();
            new KaKaoMapView().InitMap();
        }
    }
}
