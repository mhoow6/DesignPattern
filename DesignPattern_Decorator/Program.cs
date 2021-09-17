using System;

namespace DesignPattern_Decorator
{
    // Decorator 패턴
    // - 특정 클래스의 객체들이 할 수 있는 일을 여러가지 두고 각 객체마다 사용자가 원하는대로 골라 시키거나 필요에 따라 장착시킬때 사용
    // - 객체가 생성자 변수로 다른 객체 안에 들어감으로써 그 실행하는 메소드의 행동이 추가되도록 하는 것
    class Program
    {
        static void Main(string[] args)
        {
            FighterFactory factory = new FighterFactory();

            // 탄환 발사
            new XWingFighter().Attack();
            factory.GetFighter(false, false);

            // 탄환 발사
            // 레이저 발사
            new LaserDecorator(new XWingFighter()).Attack();
            factory.GetFighter(true, false);

        }
    }
}
