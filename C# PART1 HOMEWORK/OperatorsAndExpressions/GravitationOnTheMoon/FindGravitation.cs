/*The gravitational field of the Moon is approximately 17% of that on the Earth. 
Write a program that calculates the weight of a man on the moon by a given weight on the Earth. 
Examples:
weight  weight on the Moon

86	    14.62
74.6	12.682
53.7	9.129
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GravitationOnTheMoon
{
    class FindGravitation
    {
        static void Main(string[] args)
        {
            double[] manWeight = {86, 74.6, 53.7};
            double moonGravitation = 0.17;
            
            for (int i = 0; i < manWeight.Length; i++)
            {
                Console.WriteLine(manWeight[i] * moonGravitation);
            }
            
        }
    }
}
