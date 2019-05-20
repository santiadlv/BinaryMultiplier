using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTP.Clases
{
    class shifter
    {
        public static void rShift(string wS) //Shift the fused string one place to the right
        {
            int length = wS.Length; //Length of the string
            global.wholeString = wS.Remove(length - 1,1).PadLeft(length, wS[0]); //Remove last char, insert a copy of the first char up front
        }
    }
}
