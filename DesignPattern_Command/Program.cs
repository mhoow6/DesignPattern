using System;

// 커맨드 패턴
// - 하는 일 자체를 다르게 하는 방법
// - 전략패턴과 비슷한 방식으로 구현하게 하는 방법 존재
// - 여러 일을 목록으로 실어보내서 차례대로 실행하게 하는 방법 존재

namespace DesignPattern_Command
{
    class Program
    {
        static void Main(string[] args)
        {
            RobotKit robotKit = new RobotKit();

            robotKit.AddCommand(new MoveForwardCommand(2));
            robotKit.AddCommand(new TurnCommand(Robot.Direction.LEFT));
            robotKit.AddCommand(new MoveForwardCommand(1));
            robotKit.AddCommand(new TurnCommand(Robot.Direction.RIGHT));
            robotKit.AddCommand(new PickupCommand());

            robotKit.Start();
        }
    }
}
