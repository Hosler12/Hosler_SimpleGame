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
using System.Windows.Shapes;
using Demo_Wpf_TheSimpleGame.Models;

namespace Demo_Wpf_TheSimpleGame.Presentation
{
    /// <summary>
    /// Interaction logic for TheSimpleGameView.xaml
    /// </summary>
    public partial class GameView : Window
    {
        GameViewModel _gameViewModel;
        public GameView(GameViewModel gameViewModel)
        {
            _gameViewModel = gameViewModel;
            InitializeComponent();
        }

        private void Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = sender as Button;
            switch (clickedButton.Name)
            {
                case "NewGame":
                    _gameViewModel.GameCommand(clickedButton.Name);
                    break;
                case "ResetGame":
                    _gameViewModel.GameCommand(clickedButton.Name);
                    break;
                case "QuitSave":
                    _gameViewModel.GameCommand(clickedButton.Name);
                    break;
                case "Quit":
                    Close();
                    _gameViewModel.GameCommand(clickedButton.Name);
                    break;
                default:
                    int row = int.Parse(clickedButton.Tag.ToString().Substring(0, 1));
                    int column = int.Parse(clickedButton.Tag.ToString().Substring(1, 1));

                    _gameViewModel.PlayerMove(row, column);
                    break;
            }
        }
    }
}
