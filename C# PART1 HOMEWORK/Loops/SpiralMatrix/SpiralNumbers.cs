/*Write a program that reads from the console a positive
 integer number n (1 ≤ n ≤ 20) and prints a matrix holding 
 the numbers from 1 to n*n in the form of square spiral
 like in the examples below. 
 Examples:
n	matrix		n	matrix		n	matrix
2	1 2         3	1 2 3       4	1  2  3  4
    4 3		        8 9 4           12 13 14 5
                    7 6 5           11 16 15 6
                		            10 9  8  7                            
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiralMatrix
{
    class SpiralNumbers
    {
        static void Main(string[] args)
        {
            int n = 5;
            int[,] matrix = new int[n, n];
            int row = 0;
            int col = 0;
            string position = "right";
            int rotations = n * n;

            for (int i = 1; i <= rotations; i++)
            {
                if (position == "right" && (col > n - 1 || matrix[row, col] != 0))
                {
                    position = "down";
                    col--;
                    row++;
                }
                if (position == "down" && (row > n - 1 || matrix[row, col] != 0))
                {
                    position = "left";
                    row--;
                    col--;
                }
                if (position == "left" && (col < 0 || matrix[row, col] != 0))
                {
                    position = "up";
                    col++;
                    row--;
                    
                }
                if (position == "up" && (row < 0 || matrix[row, col] != 0))
                {
                    position = "right";
                    row++;
                    col++;
                }
                matrix[row, col] = i;
                
                if (position == "right")
                {
                    col++;
                }
                if (position == "down")
                {
                    row++;
                }
                if (position == "left")
                {
                    col--;
                }
                if (position == "up")
                {
                    row--;
                }
            }
            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    Console.Write("{0,4}", matrix[r, c]);
                }
                Console.WriteLine();
            }
        }
        
    }
}
