/*A bank account has a holder name
 (first name, middle name and last name),
 available amount of money (balance), 
 bank name, IBAN, 3 credit card numbers associated with the account. 
 Declare the variables needed to keep 
 the information for a single bank account 
 using the appropriate data types and descriptive names.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcaunt
{
    class AcauntData
    {
        static void Main(string[] args)
        {
            string firstName = "Pesho";
            string middleName = "Peshev";
            string lastName = "Peshev";
            decimal moneyBalance = 10000000000m;
            string bankName = "FiBank";
            int ibanNumber = 283718934;
            ulong cardOne = 225251267475886959u;
            ulong cardTwo = 454784585695806709u;
            ulong cardThree = 457634116536745858u;
            Console.WriteLine("First Name - {0}", firstName);
            Console.WriteLine("Middle Name - {0}", middleName);
            Console.WriteLine("Last Name - {0}", lastName);
            Console.WriteLine("Money Balance - {0}", moneyBalance); 
            Console.WriteLine("Bank Name - {0}", bankName);
            Console.WriteLine("Iban Number - {0}", ibanNumber);
            Console.WriteLine("Card One - {0}", cardOne);
            Console.WriteLine("Card Two - {0}", cardTwo);
            Console.WriteLine("Card Three - {0}", cardThree);
        }
    }
}
