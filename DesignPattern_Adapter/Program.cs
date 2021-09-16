using System;

// Adapter 패턴
// - 어답터라는 것은 형식이 다른 둘 사이에 연결되어 둘이 호환할 수 있게 하는 도구
// - 인터페이스가 서로 다른 객체들이 같은 형식 아래 작동할 수 있도록 함

namespace DesignPattern_Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            MyProgram myProgram = new MyProgram();
            myProgram.TestProgram();
        }
    }
}
