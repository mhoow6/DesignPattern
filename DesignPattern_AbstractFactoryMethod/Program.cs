using System;

namespace DesignPattern_AbstractFactoryMethod
{
    // 추상 팩토리 메소드 패턴
    // 팩토리 메소드 패턴에서 공장을 abstract이나 interface으로 함으로써 여러 종류로 하는 패턴
    class Program
    {
        static void Main(string[] args)
        {
            CompFactory lightCompFactory = new LightCompFactory();
            CompFactory darkCompFactory = new DarkCompFactory();

            Component comp1;
            Component comp2;
            Component comp3;

            comp1 = lightCompFactory.GetComp(Usage.PRESS); // 라이트 버튼 생성
            comp2 = lightCompFactory.GetComp(Usage.TOGGLE);
            comp3 = lightCompFactory.GetComp(Usage.EXPAND);

            comp1 = darkCompFactory.GetComp(Usage.PRESS); // 다크 버튼 생성
            comp2 = darkCompFactory.GetComp(Usage.TOGGLE);
            comp3 = darkCompFactory.GetComp(Usage.EXPAND);
        }
    }
}
