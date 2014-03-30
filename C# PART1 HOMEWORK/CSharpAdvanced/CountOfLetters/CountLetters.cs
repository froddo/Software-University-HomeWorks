/*Write a program that reads a list of 
 letters and prints for each letter how 
 many times it appears in the list. 
 The letters should be listed in alphabetical order. 
 Use the input and output format from the examples below. 
 Examples:
Input	                                Output
b b a a b	                            a -> 2
                                        b -> 3
	
                                        a -> 6
                                        d -> 5
h d h a a a s d f d a d j d s h a a     f -> 1
                                        h -> 3
                                        j -> 1
                                        s -> 2
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOfLetters
{
    class CountLetters
    {
        static void Main(string[] args)
        {
            List<string> s = new List<string>() { "h", "d", "h", "a", "a", "a", "s", "d", "f", "d", "a", "d", "j", "d", "s", "h", "a", "a"};
            List<string> ss = new List<string>() { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            s.Sort();
            
            int counter = 0;
            int count = 0;
            for (int i = 0; i < ss.Count; i++)
            {
                for (int j = 0; j < s.Count; j++)
                {
                    if (ss[i] == s[j])
                    {
                        counter++;
                        if (s.Count == 1)
                        {
                            Console.WriteLine("{0} --> {1}", ss[i], counter);
                            return;
                        }
                        s.RemoveAt(count);
                        j--;
                        
                    }
                    else if (counter == 0)
                    {
                        break;
                    }
                    else if (ss[i] != s[j] && counter != 0)
                    {
                        Console.WriteLine("{0} --> {1}", ss[i], counter);
                        break; 
                    }
                }
                counter = 0;
            }
        }
    }
}
