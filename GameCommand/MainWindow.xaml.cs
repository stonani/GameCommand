using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GameCommand
{
    public partial class MainWindow : Window
    {
        private ICommand _right;
        private ICommand _left;
        private ICommand _up;
        private ICommand _down;
        private int _playerspeed = 50;
        private movementReceiver _receiver;
        private movementInvoker _invoker;

        public MainWindow()
        {
            InitializeComponent();
            myCanvas.Focus();
            _receiver = new movementReceiver();
            _invoker = new movementInvoker();
            _right = new moveRight(_receiver, yellowPlayer, _playerspeed); 
            _left = new moveLeft(_receiver, yellowPlayer, _playerspeed);
            _up = new moveUp(_receiver, yellowPlayer, _playerspeed);
            _down = new moveDown(_receiver, yellowPlayer, _playerspeed);
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left)
            {
                _invoker.setAndExecuteCommand(_left);
            }
            if (e.Key == Key.Right)
            {
                _invoker.setAndExecuteCommand(_right);
            }
            if (e.Key == Key.Up)
            {
                _invoker.setAndExecuteCommand(_up);
            }
            if (e.Key == Key.Down)
            {
                _invoker.setAndExecuteCommand(_down);
            }            
        }

        private void buttonA_Click(object sender, RoutedEventArgs e)
        {
            _invoker.setAndExecuteCommand(_left);
        }

        private void buttonW_Click(object sender, RoutedEventArgs e)
        {
            _invoker.setAndExecuteCommand(_up);
        }

        private void buttonS_Click(object sender, RoutedEventArgs e)
        {
            _invoker.setAndExecuteCommand(_down);
        }

        private void buttonD_Click(object sender, RoutedEventArgs e)
        {
            _invoker.setAndExecuteCommand(_right);
        }
    }

     public class movementReceiver
    {
        public void movePlayerUp(Rectangle player, int playerSpeed)
        {
            Canvas.SetTop(player, Canvas.GetTop(player) - playerSpeed);
        }

        public void movePlayerDown(Rectangle player, int playerSpeed)
        {
            Canvas.SetTop(player, Canvas.GetTop(player) + playerSpeed);
        }

        public void movePlayerLeft(Rectangle player, int playerSpeed)
        {
            Canvas.SetLeft(player, Canvas.GetLeft(player) - playerSpeed);
        }

        public void movePlayerRight(Rectangle player, int playerSpeed)
        {
            Canvas.SetLeft(player, Canvas.GetLeft(player) + playerSpeed);
        }    

    }
}
