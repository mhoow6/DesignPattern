using System;

// Straegy 패턴
// Ex. 검색화면
//      같은 검색 단어이라도 검색 키워드에 따라 다른 검색 방식을 실행하도록 한다.

namespace DesignPattern_Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            MyProgram myProgram = new MyProgram();
            myProgram.testProgram();
        }
    }
}
