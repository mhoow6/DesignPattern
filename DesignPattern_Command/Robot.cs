using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_Command
{
    public class Robot
    {
        public enum Direction { LEFT, RIGHT }

        public void MoveForward(int space)
        {
            Console.WriteLine($"{space}칸 만큼 전진");
        }

        public void Turn(Direction _direction)
        {
            Console.WriteLine(
                _direction == Direction.LEFT ? "왼쪽" : "오른쪽" + "으로 방향 전환"
                );
        }

        public void PickUp()
        {
            Console.WriteLine("앞의 물건 집어들기");
        }
    }
}
