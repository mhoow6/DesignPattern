using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_Command
{
    class RobotKit
    {
        private Robot robot = new Robot();
        private List<Command> commands = new List<Command>();

        public void AddCommand(Command command)
        {
            commands.Add(command);
        }

        public void Start()
        {
            foreach (var command in commands)
            {
                command.SetRobot(robot);
                command.Execute();
            }
        }

    }
}
