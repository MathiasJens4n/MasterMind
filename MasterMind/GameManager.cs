using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace MasterMind
{
    public class GameManager
    {
        string[] colors = { "#FFFF0000", "#FF008000", "#FF0000FF", "#FF808080", "#FF000000", "#FFFFFF00", "#FFFFA500", "#FF800080" };
        Random rnd = new Random();
        Piece piece = new Piece();
        Pin pin = new Pin();
        public bool FirstPieceCorrect { get; set; }
        public string[] CorrectRow { get; set; }
        public int CorrectPlace { get; set; }
        public int CorrectColor { get; set; }
        public void SetColor(Brush color)
        {
            piece.Color = color;
        }
        public Brush GetColor()
        {
            return piece.Color;
        }
        public void GenerateCorrectAnswer()
        {
            CorrectRow = new string[4];
            for (int i = 0; i < CorrectRow.Length; i++)
            {
                CorrectRow[i] = colors[rnd.Next(0, 8)];
            }
        }

        public void CheckFirstPiece(Button piece)
        {
            if (piece.Background.ToString() == CorrectRow[0])
            {
                FirstPieceCorrect = true;
                CorrectPlace++;
            }
            else if (piece.Background.ToString() != CorrectRow[1] && piece.Background.ToString() != CorrectRow[2] && piece.Background.ToString() != CorrectRow[3])
            {
                if (piece.Background.ToString() == CorrectRow[0])
                {
                    CorrectColor++;
                }
                else if (piece.Background.ToString() == CorrectRow[1])
                {
                    CorrectColor++;
                }
                else if (piece.Background.ToString() == CorrectRow[2])
                {
                    CorrectColor++;
                }

            }
        }
        public void CheckSecondPiece(Button piece)
        {
            if (piece.Background.ToString() == CorrectRow[1])
            {
                CorrectPlace++;
            }
            else if (piece.Background.ToString() != CorrectRow[0] && piece.Background.ToString() != CorrectRow[2] && piece.Background.ToString() != CorrectRow[3])
            {
                if (piece.Background.ToString() == CorrectRow[0])
                {
                    CorrectColor++;
                }
                else if (piece.Background.ToString() == CorrectRow[2])
                {
                    CorrectColor++;
                }
                else if (piece.Background.ToString() == CorrectRow[3])
                {
                    CorrectColor++;
                }

            }
        }
        public void CheckThirdPiece(Button piece)
        {
            if (piece.Background.ToString() == CorrectRow[2])
            {
                CorrectPlace++;
            }
            else if (piece.Background.ToString() != CorrectRow[0] && piece.Background.ToString() != CorrectRow[1] && piece.Background.ToString() != CorrectRow[3])
            {
                if (piece.Background.ToString() == CorrectRow[0])
                {
                    CorrectColor++;
                }
                else if (piece.Background.ToString() == CorrectRow[1])
                {
                    CorrectColor++;
                }
                else if (piece.Background.ToString() == CorrectRow[3])
                {
                    CorrectColor++;
                }

            }
        }
        public void CheckFourthPiece(Button piece)
        {
            if (piece.Background.ToString() == CorrectRow[3])
            {
                CorrectPlace++;
            }
            else if (piece.Background.ToString() != CorrectRow[0] && piece.Background.ToString() != CorrectRow[1] && piece.Background.ToString() != CorrectRow[2])
            {
                if (piece.Background.ToString() == CorrectRow[0])
                {
                    CorrectColor++;
                }
                else if (piece.Background.ToString() == CorrectRow[1])
                {
                    CorrectColor++;
                }
                else if (piece.Background.ToString() == CorrectRow[2])
                {
                    CorrectColor++;
                }

            }
        }
        public void UpdatePins(Button[] pin)
        {
            for (int i = 0; i < pin.Length; i++)
            {
                if (CorrectPlace > 0)
                {
                    pin[i].Background = Brushes.Black;
                    CorrectPlace--;
                }
                else if (CorrectColor > 0)
                {
                    pin[i].Background = Brushes.SlateGray;
                    CorrectColor--;

                }
            }
            CorrectPlace = 0;
            CorrectColor = 0;
        }
    }
}
