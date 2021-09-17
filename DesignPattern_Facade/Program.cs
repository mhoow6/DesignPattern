using System;

// 퍼사드 패턴
// - Facade는 프랑스어로, 외벽이라는 뜻이다.
// - 여러 클래스의 객체들을 복합적으로 사용할 때 사용
// - 구현부는 외벽 뒤에 숨겨두고, 작업을 실행할 때는 외벽에 달린 스위치를 사용

namespace DesignPattern_Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            new MyLocFacade().PrintMyAddress();
        }
    }
}
