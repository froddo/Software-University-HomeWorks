/*We are given 5 integer numbers. 
 Write a program that finds all 
 subsets of these numbers whose sum is 0. 
 Assume that repeating the same subset 
 several times is not a problem. 
 Examples:
numbers	            result
3  -2  1  1 8	    -2 + 1 + 1 = 0
3 1 -7 35 22	    no zero subset
1 3 -4 -2 -1	    1 + -1 = 0
                    1 + 3 + -4 = 0
                    3 + -2 + -1 = 0
1 1 1 -1 -1	        1 + -1 = 0
                    1 + 1 + -1 + -1 = 0
                    1 + -1 + 1 + -1 = 0
…
0 0 0 0 0	        0 + 0 + 0 + 0 + 0 = 0
Hint: you may check for zero each of the 32 subsets with 32 if statements.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroSubset
{
    class Substet
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter five integer numbers");
            Console.Write("one = ");
            int one = int.Parse(Console.ReadLine());
            Console.Write("two = ");
            int two = int.Parse(Console.ReadLine());
            Console.Write("three = ");
            int three = int.Parse(Console.ReadLine());
            Console.Write("four = ");
            int four = int.Parse(Console.ReadLine());
            Console.Write("five = ");
            int five = int.Parse(Console.ReadLine());
            int[] number = {one, two, three, four, five };
            
            
            int counter = 0;
            int temp = 2;
            int count = 3;
            List<int> mix = new List<int>();
            
            if (number[0] + number[1] + number[2] + number[3] + number[4] == 0) // for all equal numbers
            {
                Console.Write("{0} + {1} + {2} + {3} + {4} = {5} ", number[0], number[1], number[2], number[3], number[4],
                    number[0] + number[1] + number[2] + number[3] + number[4]);
                counter++;
                return;
            }
            
            for (int k = 0; k < number.Length; k++) //for 2 subset
            {
                for (int m = 1 + k; m < number.Length; m++)
                {
                    if (number[k] + number[m] == 0)
                    {
                        counter++;
                        mix.Add(number[k]);
                        mix.Add(number[m]);
                        foreach (var item in mix)
                        {
                            Console.Write(item + " ");
                        }
                        Console.Write("= 0");
                        Console.WriteLine();
                        mix.Clear();
                    }
                }
            }
            
            for (int i = 0; i < number.Length; i++) // for 3 subset
            {
                for (int j = 1 + i; j < number.Length; j++)
                {
                    if (j == temp)
                    {
                        temp++;
                    }
                    if (number[i] + number[j] + number[temp] == 0)
                    {
                        counter++;
                        mix.Add(number[i]);
                        mix.Add(number[j]);
                        mix.Add(number[temp]);
                        foreach (var item in mix)
                        {
                            Console.Write(item + " ");
                        }
                        Console.Write("= 0");
                        Console.WriteLine();
                        mix.Clear();
                    }
                    temp++;
                    if (temp == number.Length)
                    {
                        temp = j;
                        break;
                    }
                }
            }
            temp = 2;
            
            for (int p = 0; p < number.Length; p++) // for 4 subset
            {
                for (int n = 1 + p; n < number.Length; n++)
                {
                    if (n == temp)
                    {
                        temp++;
                    }
                    if (temp == count)
                    {
                        count++;
                    }
                    if (count == number.Length)
                    {
                        count = temp;
                        temp = n;
                        break;
                    }
                    if (number[p] + number[n] + number[temp] + number[count] == 0)
                    {
                        counter++;
                        mix.Add(number[p]);
                        mix.Add(number[n]);
                        mix.Add(number[temp]);
                        mix.Add(number[count]);
                        foreach (var item in mix)
                        {
                            Console.Write(item + " ");
                        }
                        Console.Write("= 0");
                        Console.WriteLine();
                        mix.Clear();
                    }
                    
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("no subset");
            }
            

            //Another result
            
            //Console.WriteLine("Please enter five different integer numbers: ");
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());
            //int d = int.Parse(Console.ReadLine());
            //int e = int.Parse(Console.ReadLine());

            //// 5 digits

            //if (a + b + c + d + e == 0)
            //{
            //    Console.Write("The sum of the elements is equal to zero is: {0} + {1} + {2} + {3} + {4} = ", a, b, c, d, e);
            //    Console.WriteLine(a + b + c + d + e);
            //}

            //// 4 digits

            //else if (a + b + c + d == 0)
            //{
            //    Console.Write("The sum of the elements is equal to zero is: {0} + {1} + {2} + {3} = ", a, b, c, d);
            //    Console.WriteLine(a + b + c + d);
            //}
            //else if (a + b + c + e == 0)
            //{
            //    Console.Write("The sum of the elements is equal to zero is: {0} + {1} + {2} + {3} = ", a, b, c, e);
            //    Console.WriteLine(a + b + c + e);
            //}
            //else if (a + b + e + d == 0)
            //{
            //    Console.Write("The sum of the elements is equal to zero is: {0} + {1} + {2} + {3} = ", a, b, e, d);
            //    Console.WriteLine(a + b + e + d);
            //}
            //else if (a + c + d + e == 0)
            //{
            //    Console.Write("The sum of the elements is equal to zero is: {0} + {1} + {2} + {3} = ", a, c, d, e);
            //    Console.WriteLine(a + c + d + e);
            //}
            //else if (b + c + d + e == 0)
            //{
            //    Console.Write("The sum of the elements is equal to zero is: {0} + {1} + {2} + {3} = ", b, c, d, e);
            //    Console.WriteLine(b + c + d + e);
            //}

            //// 3 digits

            //else if (a + b + c == 0)
            //{
            //    Console.Write("The sum of the elements is equal to zero is: {0} + {1} + {2} = ", a, b, c);
            //    Console.WriteLine(a + b + c);
            //}
            //else if (a + b + d == 0)
            //{
            //    Console.Write("The sum of the elements is equal to zero is: {0} + {1} + {2} = ", a, b, d);
            //    Console.WriteLine(a + b + d);
            //}
            //else if (a + b + e == 0)
            //{
            //    Console.Write("The sum of the elements is equal to zero is: {0} + {1} + {2} = ", a, b, e);
            //    Console.WriteLine(a + b + e);
            //}
            //else if (b + c + d == 0)
            //{
            //    Console.Write("The sum of the elements is equal to zero is: {0} + {1} + {2} = ", b, c, d);
            //    Console.WriteLine(b + c + d);
            //}
            //else if (b + c + e == 0)
            //{
            //    Console.Write("The sum of the elements is equal to zero is: {0} + {1} + {2} = ", b, c, e);
            //    Console.WriteLine(b + c + e);
            //}
            //else if (b + d + e == 0)
            //{
            //    Console.Write("The sum of the elements is equal to zero is: {0} + {1} + {2} = ", b, d, e);
            //    Console.WriteLine(b + d + e);
            //}
            //else if (c + d + e == 0)
            //{
            //    Console.Write("The sum of the elements is equal to zero is: {0} + {1} + {2} = ", c, d, e);
            //    Console.WriteLine(c + d + e);
            //}
            //else if (c + a + e == 0)
            //{
            //    Console.Write("The sum of the elements is equal to zero is: {0} + {1} + {2} = ", c, a, e);
            //    Console.WriteLine(c + a + e);
            //}
            //else if (e + a + d == 0)
            //{
            //    Console.Write("The sum of the elements is equal to zero is: {0} + {1} + {2} = ", e, a, d);
            //    Console.WriteLine(e + a + d);
            //}
            //else if (a + c + d == 0)
            //{
            //    Console.Write("The sum of the elements is equal to zero is: {0} + {1} + {2} = ", a, c, d);
            //    Console.WriteLine(a + c + d);
            //}

            //// 2 digits

            //else if (a + b == 0)
            //{
            //    Console.Write("The sum of the elements is equal to zero is: {0} + {1} = ", a, b);
            //    Console.WriteLine(a + b);
            //}
            //else if (a + c == 0)
            //{
            //    Console.Write("The sum of the elements is equal to zero is: {0} + {1} = ", a, c);
            //    Console.WriteLine(a + c);
            //}
            //else if (a + d == 0)
            //{
            //    Console.Write("The sum of the elements is equal to zero is: {0} + {1} = ", a, d);
            //    Console.WriteLine(a + d);
            //}
            //else if (a + e == 0)
            //{
            //    Console.Write("The sum of the elements is equal to zero is: {0} + {1} = ", a, e);
            //    Console.WriteLine(a + e);
            //}
            //else if (b + c == 0)
            //{
            //    Console.Write("The sum of the elements is equal to zero is: {0} + {1} = ", b, c);
            //    Console.WriteLine(b + c);
            //}
            //else if (b + d == 0)
            //{
            //    Console.Write("The sum of the elements is equal to zero is: {0} + {1} = ", b, d);
            //    Console.WriteLine(b + d);
            //}
            //else if (b + e == 0)
            //{
            //    Console.Write("The sum of the elements is equal to zero is: {0} + {1} = ", b, e);
            //    Console.WriteLine(b + e);
            //}
            //else if (c + d == 0)
            //{
            //    Console.Write("The sum of the elements is equal to zero is: {0} + {1} = ", c, d);
            //    Console.WriteLine(c + d);
            //}
            //else if (c + e == 0)
            //{
            //    Console.Write("The sum of the elements is equal to zero is: {0} + {1} = ", c, e);
            //    Console.WriteLine(c + e);
            //}
            //else if (d + e == 0)
            //{
            //    Console.Write("The sum of the elements is equal to zero is: {0} + {1} = ", d, e);
            //    Console.WriteLine(d + e);
            //}

            //// 1 digit

            //else if (a == 0)
            //{
            //    Console.WriteLine("The sum of the elements is equal to zero is: {0} ", a);
            //}
            //else if (b == 0)
            //{
            //    Console.WriteLine("The sum of the elements is equal to zero is: {0} ", b);
            //}
            //else if (c == 0)
            //{
            //    Console.WriteLine("The sum of the elements is equal to zero is: {0} ", c);
            //}
            //else if (d == 0)
            //{
            //    Console.WriteLine("The sum of the elements is equal to zero is: {0} ", d);
            //}
            //else if (e == 0)
            //{
            //    Console.WriteLine("The sum of the elements is equal to zero is: {0} ", e);
            //}
            //else
            //{
            //    Console.WriteLine("The sum of none of the subsets is not equal to zero");
            //}


            //Another result

            /* Console.WriteLine("Enter five different integer numbers: ");

         int a = int.Parse(Console.ReadLine());
         int b = int.Parse(Console.ReadLine());
         int c = int.Parse(Console.ReadLine());
         int d = int.Parse(Console.ReadLine());
         int e = int.Parse(Console.ReadLine());

         int sum = 0;
         
         for (int c1 = 0; c1 <= 1; c1++)
         {
             for (int c2 = 0; c2 <= 1; c2++)
             {
                 for (int c3 = 0; c3 <= 1; c3++)
                 {
                     for (int c4 = 0; c4 <= 1; c4++)
                     {
                         for (int c5 = 0; c5 <= 1; c5++)
                         {
                             if ((c1 != 0) || (c2 != 0) || (c3 != 0) || (c4 != 0) || (c5 != 0))
                             {
                                 sum = c1 * a + c2 * b + c3 * c + c4 * d + c5 * e;
                                 if (sum == 0)
                                 {
                                     Console.WriteLine("Sum = 0");
                                     return;
                                 }
                             }
                         }
                     }
                 }
             }
         }
         Console.WriteLine("The sum of none of the subsets is not equal to zero");*/
        }
    }
}
