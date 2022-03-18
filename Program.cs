using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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
 *  victory calculated
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
 *  1 | 2 | 3               // 1 = 11  2 = 15   3 = 19
 * ___|___|___ 
 *    |   |   
 *  4 | 5 | 6 
 * ___|___|___
 *    |   |   
 *  7 | 8 | 9 
 *    |   |
 * 
 */