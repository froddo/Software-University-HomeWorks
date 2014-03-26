/**/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumber
{
    class MaxOfNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number for a, b, c");
            Console.Write("a = ");
            double firstNum = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double secondNum = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double thirdNum = double.Parse(Console.ReadLine());

            if (firstNum > secondNum && firstNum > thirdNum)
            {
                Console.WriteLine("The biggest number is: {0}", firstNum);
            }
            else if (secondNum > firstNum && secondNum > thirdNum)
            {
                Console.WriteLine("The biggest number is: {0}", secondNum);
            }
            else if (thirdNum > firstNum && thirdNum > secondNum)
            {
                Console.WriteLine("The biggest number is: {0}", thirdNum);
            }

            // Another result

            //double[] result = {firstNum, secondNum, thirdNum };
            //double biggestNum = result.Max();
            //Console.WriteLine("The biggest number is: {0}", biggestNum);
        }
    }
}
