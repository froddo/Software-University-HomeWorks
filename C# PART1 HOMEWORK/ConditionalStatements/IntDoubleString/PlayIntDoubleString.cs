/*Write a program that, depending on the user’s 
 choice, inputs an int, double or string variable. 
 If the variable is int or double, the program increases it by one. 
 If the variable is a string, the program appends "*" at the end. 
 Print the result at the console. Use switch statement. 
 Example:
program	                user		        program	                user
Please choose a type:
1 --> int
2 --> double
3 --> string	        3		            Please choose a type:
                                            1 --> int
                                            2 --> double
                                            3 --> string	        2
Please enter a string:	hello		        Please enter a double:	1.5
hello*			                            2.5	
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntDoubleString
{
    class PlayIntDoubleString
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter 1--> integer, 2--> double, 3-->string ");
            int choise = int.Parse(Console.ReadLine());

            switch (choise)
            {
                case 1:
                    Console.Write("Please enter integer number ");
                    int integerNum = int.Parse(Console.ReadLine());
                    Console.WriteLine(integerNum = integerNum + 1);
                    break;
                case 2:
                    Console.Write("Please enter double number ");
                    double doubleNum = double.Parse(Console.ReadLine());
                    Console.WriteLine(doubleNum = doubleNum + 1);
                    break;
                case 3:
                    Console.Write("Please enter a string ");
                    string name = Console.ReadLine();
                    Console.WriteLine(name + "*");
                    break;
                default:
                    break;
            }
            
            
            // Some Interesting
            
            //string choise = Console.ReadLine();
            //int value;
            //double valueSec;

            //if (int.TryParse(choise, out value))
            //{
            //    Console.WriteLine(value = value + 1);
            //}
            //else if (double.TryParse(choise, out valueSec))
            //{
            //    Console.WriteLine(valueSec = valueSec + 1);
            //}
            //else
            //{
            //    string star = "*";
            //    Console.WriteLine("{0}{1}", choise, star);
            //}

            //Another one
            
            //string choise = Console.ReadLine();
            //int value;
            //double valueSec;
            //string star = "*";
            //if (int.TryParse(choise, out value))
            //{
            //    switch (value)
            //    {
                    
            //        default:
            //            Console.WriteLine(value = value + 1);
            //            break;
            //    }
            //}
            //else if (double.TryParse(choise, out valueSec))
            //{
            //    switch (valueSec.ToString())
            //    {
            //        default:
            //            Console.WriteLine(valueSec = valueSec + 1);
            //            break;
            //    }
            //}
            //else
            //{
            //    switch (choise)
            //    {
            //        default:
            //            Console.WriteLine("{0}{1}", choise, star);
            //            break;
            //    }
            //}

            //Another one

            //string chose = Console.ReadLine();
            //int value;
            //double valueSec;

            //int.TryParse(chose, out value);

            //double.TryParse(chose, out valueSec);

            //if (valueSec % 1 != 0)
            //{
            //    Console.WriteLine(valueSec = valueSec + 1);
            //}
            //else if (value % 1 == 0)
            //{
            //    Console.WriteLine(value = value + 1);
            //}
            //else
            //{
            //    Console.WriteLine(chose + "*");
            //}
            
        }
    }
}
