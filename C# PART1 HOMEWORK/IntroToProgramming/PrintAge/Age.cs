/** Write a program to read your
  age from the console and print
  how old you will be after 10 years.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintAge
{
    class Age
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter, how old are you! --> ");
            int age = int.Parse(Console.ReadLine());
            int futureAge = age + 10;
            Console.Write("After ten years, will be on    -->");
            Console.WriteLine(" {0}", futureAge);
        }
    }
}
