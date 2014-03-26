/*Write a program that generates and prints all 
 possible cards from a standard deck of 52 cards 
 (without the jokers). 
 The cards should be printed using the classical notation 
 (like 5♠, A♥, 9♣ and K♦). 
 The card faces should start from 2 to A. 
 Print each card face in its four possible suits: 
 clubs, diamonds, hearts and spades. 
 Use 2 nested for-loops and a switch-case statement.
output
2♣ 2♦ 2♥ 2♠
3♣ 3♦ 3♥ 3♠
…
K♣ K♦ K♥ K♠
A♣ A♦ A♥ A♠
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintCards
{
    class DeckOfCards
    {
        static void Main(string[] args)
        {
            string[] cards = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            int[] suit = {5, 4, 3, 6};

            for (int j = 0; j < cards.Length; j++)
            {
                Console.Write("{0,4}", cards[j] + (char)suit[0]);
                Console.Write("{0,4}", cards[j] + (char)suit[1]);
                Console.Write("{0,4}", cards[j] + (char)suit[2]);
                Console.Write("{0,4}", cards[j] + (char)suit[3]);
                Console.WriteLine();
            }
        }
    }
}
