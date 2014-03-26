/*A marketing company wants to keep record of its employees. 
 Each record would have the following characteristics:
	First name
	Last name
	Age (0...100)
	Gender (m or f)
	Personal ID number (e.g. 8306112507)
	Unique employee number (27560000…27569999)
Declare the variables needed to keep the information 
 for a single employee using appropriate primitive data types. 
 Use descriptive names. Print the data at the console.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            string furstName = "Pesho";
            string lastName = "Peshev";
            byte age = 25;
            char gender = '\u004D';
            long idNumber = 8306112507;
            ulong uniqueNumber = 2756000027569999;
            Console.WriteLine("My furst name is: {0}", furstName);
            Console.WriteLine("My family name is : {0}", lastName);
            Console.WriteLine("I am {0}", age + " " + "years old");
            Console.WriteLine("My gender is: {0}", gender);
            Console.WriteLine("My Id number is: {0}", idNumber);
            Console.WriteLine("My unique number is: {0}", uniqueNumber);
        }
    }
}
