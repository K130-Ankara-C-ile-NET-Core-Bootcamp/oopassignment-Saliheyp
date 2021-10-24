using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment
{
    public class CarStringCommandExecutor : CarCommandExecutorBase, IStringCommand
    {
        public CarStringCommandExecutor(ICarCommand carCommand) : base(carCommand)
        {
        }

        public void ExecuteCommand(string commandObject)
        {
            if (string.IsNullOrWhiteSpace(commandObject))
            {
                throw new Exception();
            }
            else
            {
                foreach (var command in commandObject)
                {
                    if (command == 'L')
                    {
                        CarCommand.TurnLeft();
                    }
                    else if (command == 'R')
                    {
                        CarCommand.TurnRight();
                    }
                    else if (command == 'M')
                    {
                        CarCommand.Move();
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
            }
        }
    }
}
