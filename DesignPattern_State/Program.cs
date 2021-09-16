using System;

// 상태(State) 패턴
// - 특정 상태마다 다르게 할 일, 상태 그 자체, 상태에서의 할 일을 모듈화해서 지정해 줄 때 사용
// - 전략(Strategy) 패턴은 동일한 틀 안에 있는 모드를 바꿔줄 때 사용한 다는 것에 차이
// - 전략 패턴에서 모듈화된 모드에 따라 다르게 실행되는 것이라면, 상태 패턴은 모드까지 바꿔버리는 것이라 이해

namespace DesignPattern_State
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
