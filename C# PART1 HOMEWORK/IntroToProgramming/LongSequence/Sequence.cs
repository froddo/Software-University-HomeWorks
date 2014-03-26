/*Write a program that prints the 
 first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, … 
 You might need to learn how to use loops (search in Internet).*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongSequence
{
    class Sequence
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 1000; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(-i);
                }
            }
        }
    }
}
