/*Declare five variables choosing for each of them 
 the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong 
 to represent the following values: 52130, -115, 4825932, 97, -10000.
 Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclareVariables
{
    class Variables
    {
        static void Main(string[] args)
        {
            ushort small = 52130;
            sbyte negative = -115;
            int integer = 4825932;
            byte simple = 97;
            short negativeNumber = -10000;
        }
    }
}
