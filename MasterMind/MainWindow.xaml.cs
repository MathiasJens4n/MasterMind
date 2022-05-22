using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace MasterMind
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GameManager gameMng = new GameManager();
        int round = 1;


        public MainWindow()
        {
            InitializeComponent();
            gameMng.GenerateCorrectAnswer();
            Debug.WriteLine($"{gameMng.CorrectRow[0]} {gameMng.CorrectRow[1]} {gameMng.CorrectRow[2]} {gameMng.CorrectRow[3]}");
        }

        public void Check()
        {
            switch (round)
            {
                case 1:
                    gameMng.CheckFirstPiece(button00);
                    gameMng.CheckSecondPiece(button01);
                    gameMng.CheckThirdPiece(button02);
                    gameMng.CheckFourthPiece(button03);
                    gameMng.UpdatePins(new Button[] { Pin00Button, Pin01Button, Pin02Button, Pin03Button });
                    break;
                case 2:
                    gameMng.CheckFirstPiece(button10);
                    gameMng.CheckSecondPiece(button11);
                    gameMng.CheckThirdPiece(button12);
                    gameMng.CheckFourthPiece(button13);
                    gameMng.UpdatePins(new Button[] { Pin10Button, Pin11Button, Pin12Button, Pin13Button });
                    break;
                case 3:
                    gameMng.CheckFirstPiece(button20);
                    gameMng.CheckSecondPiece(button21);
                    gameMng.CheckThirdPiece(button22);
                    gameMng.CheckFourthPiece(button23);
                    gameMng.UpdatePins(new Button[] { Pin20Button, Pin21Button, Pin22Button, Pin23Button });
                    break;
                case 4:
                    gameMng.CheckFirstPiece(button30);
                    gameMng.CheckSecondPiece(button31);
                    gameMng.CheckThirdPiece(button32);
                    gameMng.CheckFourthPiece(button33);
                    gameMng.UpdatePins(new Button[] { Pin30Button, Pin31Button, Pin32Button, Pin33Button });
                    break;
                case 5:
                    gameMng.CheckFirstPiece(button40);
                    gameMng.CheckSecondPiece(button41);
                    gameMng.CheckThirdPiece(button42);
                    gameMng.CheckFourthPiece(button43);
                    gameMng.UpdatePins(new Button[] { Pin40Button, Pin41Button, Pin42Button, Pin43Button });
                    break;
                case 6:
                    gameMng.CheckFirstPiece(button50);
                    gameMng.CheckSecondPiece(button51);
                    gameMng.CheckThirdPiece(button52);
                    gameMng.CheckFourthPiece(button53);
                    gameMng.UpdatePins(new Button[] { Pin50Button, Pin51Button, Pin52Button, Pin53Button });
                    break;
                case 7:
                    gameMng.CheckFirstPiece(button60);
                    gameMng.CheckSecondPiece(button61);
                    gameMng.CheckThirdPiece(button62);
                    gameMng.CheckFourthPiece(button63);
                    gameMng.UpdatePins(new Button[] { Pin60Button, Pin61Button, Pin62Button, Pin63Button });
                    break;
                case 8:
                    gameMng.CheckFirstPiece(button70);
                    gameMng.CheckSecondPiece(button71);
                    gameMng.CheckThirdPiece(button72);
                    gameMng.CheckFourthPiece(button73);
                    gameMng.UpdatePins(new Button[] { Pin70Button, Pin71Button, Pin72Button, Pin73Button });
                    break;
            }
            round++;
        }

        private void RedButton_Click(object sender, RoutedEventArgs e)
        {
            gameMng.SetColor(redButton.Background);
        }

        private void GreenButton_Click(object sender, RoutedEventArgs e)
        {
            gameMng.SetColor(greenButton.Background);
        }

        //Handles what color is chosen
        private void BlueButton_Click(object sender, RoutedEventArgs e)
        {
            gameMng.SetColor(blueButton.Background);
        }

        private void WhiteButton_Click(object sender, RoutedEventArgs e)
        {
            gameMng.SetColor(whiteButton.Background);
        }

        private void BlackButton_Click(object sender, RoutedEventArgs e)
        {
            gameMng.SetColor(blackButton.Background);
        }

        private void YellowButton_Click(object sender, RoutedEventArgs e)
        {
            gameMng.SetColor(yellowButton.Background);
        }

        private void OrangeButton_Click(object sender, RoutedEventArgs e)
        {
            gameMng.SetColor(orangeButton.Background);
        }

        private void PurpleButton_Click(object sender, RoutedEventArgs e)
        {
            gameMng.SetColor(purpleButton.Background);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = e.Source as Button;
            button.Background = gameMng.GetColor();
        }

        private void CheckButton_Click(object sender, RoutedEventArgs e)
        {
            Check();
        }
    }
}
