/*A company has name, address, phone number, fax number, web site and manager. 
 The manager has first name, last name, age and a phone number. 
 Write a program that reads the information about a 
 company and its manager and prints it back on the console.
program	user
Company name:	Software University
Company address:	26 V. Kanchev, Sofia
Phone number:	+359 899 55 55 92
Fax number:	
Web site:	http://softuni.bg

Manager first name:	Svetlin
Manager last name:	Nakov
Manager age:	25
Manager phone:	+359 2 981 981
Software University
Address: 26 V. Kanchev, Sofia
Tel. +359 899 55 55 92
Fax: (no fax)
Web site: http://softuni.bg
Manager: Svetlin Nakov (age: 25, tel. +359 2 981 981)	
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyInformation
{
    class PrintInformation
    {
        static void Main(string[] args)
        {
            string name = "Company Name:";
            string companyName = "Software University";
            Console.WriteLine(name + " " + companyName);
            string adress = "Company Adress:";
            string companyAddress = "26 V. Kanchev, Sofia";
            Console.WriteLine(adress + " " + companyAddress);
            string phone = "Phone Number:";
            char simbol = '+';
            long phoneNumber = 359899555592;
            Console.Write(phone + " " + simbol);
            Console.WriteLine("{0:## ### ## ## ##}", phoneNumber);
            string fax = "Fax Number:";
            string faxNumber = null;
            Console.WriteLine(fax + " " + faxNumber);
            string site = "WebSite:";
            string website = "http://softuni.bg";
            Console.WriteLine(site + " " + website);
            string firstName = "Manager First Name:";
            string managerFirstName = "Svetlin";
            Console.WriteLine(firstName + " " + managerFirstName);
            string lastName = "Manager Last Name:";
            string managerLastName = "Nakov";
            Console.WriteLine(lastName + " " + managerLastName);
            string age = "Manager Age:";
            byte managerAge = 25;
            Console.WriteLine(age + " " + managerAge);
            string managerNumber = "Manager Phone:";
            long managerPhone = 3592981981;
            Console.Write(managerNumber + " " + simbol);
            Console.WriteLine("{0:# # ### ###}", managerPhone);
            string university = "Software University";
            string softwareUniversity = " ";
            Console.WriteLine(university + " " + softwareUniversity);

        }
    }
}
