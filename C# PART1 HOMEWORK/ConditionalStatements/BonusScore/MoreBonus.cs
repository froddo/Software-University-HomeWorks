/*Write a program that applies bonus score to given score in the range
 [1…9] by the following rules:
•	If the score is between 1 and 3, the program multiplies it by 10.
•	If the score is between 4 and 6, the program multiplies it by 100.
•	If the score is between 7 and 9, the program multiplies it by 1000.
•	If the score is 0 or more than 9, the program prints “invalid score”.
Examples:
score	result
2	    20
4	    400
9	    9000
-1	    invalid score
10	    invalid score
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    class MoreBonus
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integer number in range [1-9]: ");
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Console.WriteLine(1 * 10);
                    break;
                case 2:
                    Console.WriteLine(2 * 10);
                    break;
                case 3:
                    Console.WriteLine(3 * 10);
                    break;
                case 4:
                    Console.WriteLine(4 * 100);
                    break;
                case 5:
                    Console.WriteLine(5 * 100);
                    break;
                case 6:
                    Console.WriteLine(6 * 100);
                    break;
                case 7:
                    Console.WriteLine(7 * 1000);
                    break;
                case 8:
                    Console.WriteLine(8 * 1000);
                    break;
                case 9:
                    Console.WriteLine(9 * 1000);
                    break;
                default:
                    Console.WriteLine("invalid score");
                    break;
            }
        }
    }
}
