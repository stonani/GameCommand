using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace GameCommand
{
    class moveUp : ICommand
    {
        private movementReceiver _receiver;
        private Rectangle _player;
        private int _playerSpeed;

        public moveUp(movementReceiver receiver, Rectangle player, int playerSpeed)
        {
            _receiver = receiver;
            _player = player;
            _playerSpeed = playerSpeed;
        }

        public void execute()
        {
            _receiver.movePlayerUp(_player, _playerSpeed);
        }
    }
}
