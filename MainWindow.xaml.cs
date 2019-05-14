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

namespace BomberMan_UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        enum GameState { startScreen, gameOn, optionsScreen, gameOver}
        GameState gameState;
        public MainWindow()
        {
            InitializeComponent();
            gameState = GameState.startScreen;
            
        }

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            gameState = GameState.gameOn;
            checkState();
        }

        private void BtnOptions_Click(object sender, RoutedEventArgs e)
        {
            gameState = GameState.optionsScreen;
            checkState();
        }

        private void BtnReturn_Click(object sender, RoutedEventArgs e)
        {
            gameState = GameState.startScreen;
            checkState();
        }


        private void checkState()
        {
            switch(gameState)
            {
                case GameState.gameOn:
                    {
                        MessageBox.Show("GAME ON!");
                        break;
                    }
                case GameState.optionsScreen:
                    {
                        MessageBox.Show("Options or w/e");
                        break;
                    }
            }
        }
    }
}
