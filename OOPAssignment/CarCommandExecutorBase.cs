using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment
{
    public class CarCommandExecutorBase
    {
        protected ICarCommand CarCommand { get; }
        public CarCommandExecutorBase(ICarCommand carCommand)
        {
            CarCommand = carCommand;
        }
    }
}
