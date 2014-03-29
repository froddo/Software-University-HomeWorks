/*Write a program that enters two dates in format dd.MM.yyyy and returns the number of days between them.
 Examples:
First date
Second date	Days between
17.03.2014
30.04.2014	44
17.03.2014
17.03.2014	0
14.06.1980
5.03.2014	12317
5.03.2014
3.03.2014	-2
*/

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferenceDates
{
    class DataCheck
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter two dates");
            Console.Write("Enter first date: ");
            string time = Console.ReadLine();
            DateTime firstDate = DateTime.Parse(time);
            firstDate.ToString("dd.MM.yyyy");

            Console.Write("Enter second date: ");
            string secondTime = Console.ReadLine();
            DateTime secondDate = DateTime.Parse(secondTime);
            secondDate.ToString("dd.MM.yyyy");
            TimeSpan diff = secondDate - firstDate;
            double days = diff.TotalDays;
            Console.WriteLine(days);

            

            //Another result

            //Console.WriteLine("Enter two dates");
            //Console.Write("Enter first date: ");
            //string time = Console.ReadLine();
            //string format = "dd.MM.yyyy";
            //DateTime firstDate = DateTime.ParseExact(
            //time, format, CultureInfo.InvariantCulture);

            //Console.Write("Enter second date: ");
            //string secondTime = Console.ReadLine();
            //string formatTwo = "dd.MM.yyyy";
            //DateTime secondDate = DateTime.ParseExact(
            //secondTime, formatTwo, CultureInfo.InvariantCulture);

            //TimeSpan diff = secondDate - firstDate;
            //double days = diff.TotalDays;
            //Console.WriteLine(days);
        }
    }
}
