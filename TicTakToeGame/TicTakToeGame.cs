using System;
using System.Collections.Generic;
using System.Text;

namespace TicTakToeGame
{
    public class TicTakToeGame
    {
        public static void TicTakToe()
        {
            char[] board = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        }

        public static void chooseLetter()
        {
            char letter;

            Console.WriteLine("Choose a letter X or O: ");
            letter = Console.ReadLine()[0];

            if (letter == 'X')
            {
                Console.WriteLine("Player's letter is X.");
                Console.WriteLine("Computer's letter is O.");
            }
            else if (letter == 'O')
            {
                Console.WriteLine("Player's letter is O.");
                Console.WriteLine("Computer's letter is X.");
            }
            else
            {
                Console.WriteLine("Error. You have to choose X or O only.");
            }
        }

        public static void board()
        {
            Console.WriteLine("     |     |     ");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("     |     |     ");


        }
    }
}
