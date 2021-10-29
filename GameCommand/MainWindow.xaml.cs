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
        private ICommand _movement;
        private int _playerspeed = 50;
        private movementReceiver _receiver;
        public MainWindow()
        {
            InitializeComponent();
            myCanvas.Focus();
            _receiver = new movementReceiver();
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left)
            {
                _movement = new moveLeft(_receiver, yellowPlayer, _playerspeed);
                _movement.execute();
            }
            if (e.Key == Key.Right)
            {
                _movement = new moveRight(_receiver, yellowPlayer, _playerspeed);
                _movement.execute();
            }
            if (e.Key == Key.Up)
            {
                _movement = new moveUp(_receiver, yellowPlayer, _playerspeed);
                _movement.execute();
            }
            if (e.Key == Key.Down)
            {
                _movement = new moveDown(_receiver, yellowPlayer, _playerspeed);
                _movement.execute();
            }            
        }

        private void buttonA_Click(object sender, RoutedEventArgs e)
        {
            _movement = new moveLeft(_receiver, yellowPlayer, _playerspeed);
            _movement.execute();
        }

        private void buttonW_Click(object sender, RoutedEventArgs e)
        {
            _movement = new moveUp(_receiver, yellowPlayer, _playerspeed);
            _movement.execute();
        }

        private void buttonS_Click(object sender, RoutedEventArgs e)
        {
            _movement = new moveDown(_receiver, yellowPlayer, _playerspeed);
            _movement.execute();
        }

        private void buttonD_Click(object sender, RoutedEventArgs e)
        {
            _movement = new moveRight(_receiver, yellowPlayer, _playerspeed);
            _movement.execute();
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
