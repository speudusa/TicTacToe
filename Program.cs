using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayBoard();
        }

        static char[,] playerMark =
        {
            {'A', 'B', 'C'},
            {'D', 'E', 'F'},
            {'G', 'H', 'I'}
        };



        public static void DisplayBoard()
        {

            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2} ", playerMark[0,0], playerMark[0,1], playerMark[0,2]);
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2} ", playerMark[1,0], playerMark[1,1], playerMark[1,2]);
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2} ", playerMark[2, 0], playerMark[2, 1], playerMark[2, 2]);
            Console.WriteLine("   |   |   ");
        }


    }
}



//for taking turns -- while loop & modulo???
//https://stackoverflow.com/questions/55333903/switching-turns-in-a-player-game


/* Console Tic Tac Toe
 * 
 * 9 fields
 * 2 players - pick field (int) <-- but should NOT crash game if NaN
 *      - alternates turns
 *  victory calculated based on conditions of the board?
 *  
 *  asks if want to play again (while loop???)
 *  
 *  switch case, methods, 2D arrays
 * 
 * 
 * BOARD LOOKS LIKE THIS:
 * rows: 9 && col: 11
 * 
 *    |   |     
 *  {0} | {1} | {2}               // 1 = 11  2 = 15   3 = 19
 * ___|___|___              // Composite Formatting??   (see top row)
 *    |   |   
 *  4 | 5 | 6 
 * ___|___|___
 *    |   |   
 *  7 | 8 | 9 
 *    |   |
 * 
 */