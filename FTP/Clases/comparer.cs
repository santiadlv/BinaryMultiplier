using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTP.Clases
{
    class comparer
    {
        public static void compareIndexes (string Q) //Input number converted to binary string ('Q' variable)
        {
            global.wholeString = String.Concat(global.A, global.Q, global.Q_1); //Create a new string fusing A, Q and Q-1 for easier shifting
            global.strSize = global.wholeString.Length; //Get fused string length

            if (global.wholeString[global.strSize - 1] != global.wholeString[global.strSize - 2]) //Check if the last 2 bits are different
            {
                arithmeticOps.execOp(Q); //If they're not equal, determine which operation is next
                global.wholeString = String.Concat(global.A, global.Q, global.Q_1); //Redefine fused string with new 'A' value
                shifter.rShift(global.wholeString); //Shift it to the right by one char
            }
            else //If last 2 bits are equal, do...
            {
                shifter.rShift(global.wholeString); //Shift the string right away
                global.opName = "    -----     "; //Determine that there was no sum or subtraction
                global.cycle = "  " + masterControl.counter.ToString(); //Increase the cycle number
                messages.printVar(); //Print the variables on screen
            }
            global.opName = "Displacement  "; //After last operation, determine only a displacement was made
        }
    }
}
