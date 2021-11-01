using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCommand
{
    class movementInvoker
    {
        private ICommand _command;

        public void setAndExecuteCommand(ICommand command)
        {
            _command = command;
            _command.execute();
        }
    }
}
