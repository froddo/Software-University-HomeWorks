/*Write a program to generate the following 
 matrix of palindromes of 3 letters with r rows and c columns:
Input	Output
3 6	    aaa aba aca	ada aea afa
        bbb bcb bdb	beb bfb bgb
        ccc cec cdc	cfc cgc chc
2 3	    aaa aba aca
        bbb bcb bdb
1 1	    aaa
1 3	    aaa aba aca
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOfPalindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number for row and col");
            Console.Write("row = ");
            int r = int.Parse(Console.ReadLine());
            Console.Write("col = ");
            int c = int.Parse(Console.ReadLine());

            string[,] matrix = new string[r, c];

            for (int row = 0; row < r; row++)
            {
                for (int col = 0 ; col < c; col++)
                {
                    matrix[row, col] = "" + (char)('a' + row) + (char)('a' + col + row) + (char)('a' + row);
                }
            }

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
