/*Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
•	Calculates the sum of the digits (in our example 2+0+1+1 = 4).
•	Prints on the console the number in reversed order: dcba (in our example 1102).
•	Puts the last digit in the first position: dabc (in our example 1201).
•	Exchanges the second and the third digits: acbd (in our example 2101).
The number has always exactly 4 digits and cannot start with 0. Examples:

n	    sum of digits	reversed	last digit      second and third 
                                    in front	    digits exchanged
2011	4	            1102	    1201	        2101
3333	12	            3333	    3333	        3333
9876	30	            6789	    6987	        9786
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourDigitNumber
{
    class ChangeNumber
    {
        static void Main(string[] args)
        {
            int[] sumNumber = { 2011, 3333, 9876 };
            SumDigits(sumNumber);
            int[] reverseNumber = { 2011, 3333, 9876 };
            ReverseDigits(reverseNumber);
            int[] changeLastDigit = { 2011, 3333, 9876 };
            ChangeLastDigit(changeLastDigit);
            int[] digitExchanges = { 2011, 3333, 9876 };
            ExchangedDigits(digitExchanges);
        }
        static void SumDigits(int[] sumNumber)
        {
            Console.WriteLine("The Sum is: ");
            for (int i = 0; i < sumNumber.Length; i++)
            {
                List<int> sum = new List<int>();
                while (true)
                {
                    if (sumNumber[i] == 0)
                    {
                        break;
                    }
                    int temp = sumNumber[i] % 10;
                    sum.Add(temp);
                    int result = sumNumber[i] / 10;
                    sumNumber[i] = result;
                }
                int allSum = 0;
                int count = sum.Count;
                
                foreach (var item in sum)
                {
                    allSum += item;
                    Console.Write("{0} ", item);
                    count--;
                    if (count != 0)
                    {
                        Console.Write("+ ");
                    } 
                }
                Console.WriteLine("= {0}", allSum);
            } 
        }
        static void ReverseDigits(int[] reverseNumber)
        {
            Console.WriteLine("The Reverse numbers is: ");
            for (int i = 0; i < reverseNumber.Length; i++)
            {
                List<int> reverse = new List<int>();
                while (true)
                {
                    if (reverseNumber[i] == 0)
                    {
                        break;
                    }
                    int temp = reverseNumber[i] % 10;
                    reverse.Add(temp);
                    int result = reverseNumber[i] / 10;
                    reverseNumber[i] = result;
                }
                foreach (var item in reverse)
                {
                    Console.Write(item);
                }
                Console.WriteLine();
            } 
        }
        static void ChangeLastDigit(int[] changeLastDigit)
        {
            List<int> changeDigit = new List<int>();
            Console.WriteLine("The Result of change the last digit is: ");
            for (int i = 0; i < changeLastDigit.Length; i++)
            {
                int temp = changeLastDigit[i] % 10;
                changeDigit.Add(temp);
                int result = changeLastDigit[i] / 10;
                changeDigit.Add(result);
            }
            int count = 0;
            foreach (var item in changeDigit)
            {
                if (count == 2)
                {
                    Console.WriteLine();
                    count = 0;
                }
                count++;
                Console.Write(item);
            }
            Console.WriteLine();
        }
        static void ExchangedDigits(int[] digitExchanges)
        {
            List<int> exchanges = new List<int>();
            Console.WriteLine("The Second and third digits exchanged is: ");
            for (int i = 0; i < digitExchanges.Length; i++)
            {
                int temp = digitExchanges[i] / 100;
                int result = digitExchanges[i] % 100;
                int secondTemp = temp / 10;
                exchanges.Add(secondTemp);
                int secondResult  = result / 10;
                exchanges.Add(secondResult);
                temp = temp % 10;
                exchanges.Add(temp);
                result = result % 10;
                exchanges.Add(result);
            }
            int count = 0;
            foreach (var item in exchanges)
            {
                if (count == 4)
                {
                    Console.WriteLine();
                    count = 0;
                }
                count++;
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
