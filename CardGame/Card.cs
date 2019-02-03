using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class Card
    {
        public const int Red = 1;
        public const int Blue = 2;
        public const int Green = 3;
        public const int Yellow = 4;
        public const int Gold = 5;

        private int _colour;
        private int _number;

        public Card(int colour,int number)
        {
            _colour = colour;
            _number = number;
        }

        public int GetNumber()
        {
            return _number;
        }

        public int GetColour()
        {
            return _colour;
        }

        public override string ToString()
        {
            string colorString = "";
            switch (_colour)
            {
                case Red:
                    colorString = "Red";
                break;
                case Blue:
                    colorString = "Blue";
                    break;
                case Green:
                    colorString = "Green";
                    break;
                case Yellow:
                    colorString = "Yellow";
                    break;
                case Gold:
                    colorString = "Gold";
                    break;

            }

            return colorString + " " + _number.ToString();
        }
    }
}
