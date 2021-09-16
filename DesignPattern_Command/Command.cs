using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_Command
{
    abstract class Command
    {
        protected Robot robot;

        public void SetRobot(Robot _robot)
        {
            this.robot = _robot;
        }

        public abstract void Execute();
    }

    class MoveForwardCommand : Command
    {
        int space;

        public MoveForwardCommand(int _space)
        {
            space = _space;
        }

        public override void Execute()
        {
            robot.MoveForward(space);
        }
    }

    class TurnCommand : Command
    {
        Robot.Direction direction;

        public TurnCommand(Robot.Direction _direction)
        {
            direction = _direction;
        }

        public override void Execute()
        {
            robot.Turn(direction);
        }
    }

    class PickupCommand : Command
    {
        public override void Execute()
        {
            robot.PickUp();
        }
    }
}
