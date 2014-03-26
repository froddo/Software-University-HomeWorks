/*Write an expression that checks if given positive integer number n 
 (n ≤ 100) is prime (i.e. it is divisible without remainder only to itself and 1).
 Examples:
n	Prime?
1	false
2	true
3	true
4	false
9	false
97	true
51	false
-3	false
0	false
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPrime
{
    class IsPrimeNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number <= 100 ");
            int number = int.Parse(Console.ReadLine());

            int max = (int)Math.Sqrt(number);
            int counter = 2;
            
            bool isPrime = true;
            if (number == 1 || number == 0)
            {
                isPrime = false;
                Console.WriteLine("Is Prime? {0}", isPrime);
                return;
            }
            else if(0 > number)
            {
                isPrime = false;
                Console.WriteLine("Is Prime? {0}", isPrime);
                return;
            }
            while (isPrime && (counter <= max))
            {
                if (number % counter == 0)
                {
                    isPrime = false;
                    Console.WriteLine("Found divider: {0} * {1} = {2}", counter, number/counter, number);
                }
                counter++;
                
            }
            Console.WriteLine("Is Prime? {0}", isPrime);
        }
    }
}
