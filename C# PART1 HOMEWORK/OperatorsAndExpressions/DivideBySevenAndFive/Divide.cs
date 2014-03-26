/*Write a Boolean expression that checks for given integer if it can be divided 
(without remainder) by 7 and 5 in the same time. 
Examples:
n	Divided by 7 and 5?
3	false
0	false
5	false
7	false
35	true
140	true
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideBySevenAndFive
{
    class Divide
    {
        static void Main(string[] args)
        {
            int[] divide = { 3, 0, 5, 7, 35, 140, 210, 168, 155, 1225};
            
            for (int i = 0; i < divide.Length; i++)
            {
                if (divide[i] % 35 == 0 && divide[i] != 0)
                {
                    Console.WriteLine("The number {0} is devide by 7 and 5", divide[i]);
                }
            }
        }
    }
}
