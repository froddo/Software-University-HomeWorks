/*Declare two integer variables a and b 
 and assign them with 5 and 10 and after that 
 exchange their values. Print the variable values 
 before and after the exchange.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeVariable
{
    class Exchange
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("Before exchange it {0}, {1}", a, b);

            int c = a;
            a = b;
            b = c;
            Console.WriteLine("After exchange it {0}, {1}", a, b);
        }
    }
}
