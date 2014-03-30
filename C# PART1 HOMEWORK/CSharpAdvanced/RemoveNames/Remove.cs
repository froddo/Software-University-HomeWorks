/*Write a program that takes as input two lists 
 of names and removes from the first list all 
 names given in the second list. 
 The input and output lists are given as 
 words, separated by a space, each list at a separate line. 
 Examples:
Input	                                        Output
Peter Alex Maria Todor Steve Diana Steve
Todor Steve Nakov	                            Peter Alex Maria Diana
Hristo Hristo Nakov Nakov Petya
Nakov Vanessa Maria	                            Hristo Hristo Petya
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNames
{
    class Remove
    {
        static void Main(string[] args)
        {
            
            List<string> names = new List<string>() { "Peter", "Peter", "Todor", "Todor", "Diana"};
            List<string> equalNames = new List<string>() { "Todor", "Steve", "Nakov" };

            for (int i = 0; i < equalNames.Count; i++)
            {
                for (int j = 0; j < names.Count; j++)
                {
                    if (equalNames[i] == names[j])
                    {
                        names.RemoveAt(j);
                        if (j == names.Count)
                        {
                            break;
                        }
                        if (equalNames[i] == names[j])
                        {
                            names.RemoveAt(j);
                            j--;
                            continue;
                        }
                    }
                }
            }

            foreach (var item in names)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
