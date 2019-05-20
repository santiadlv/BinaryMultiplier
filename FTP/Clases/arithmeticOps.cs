using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTP.Clases
{
    class arithmeticOps
    {
        public static void execOp(string Q) //Input number converted to binary string ('Q' variable)
        {
            int adderNum = Convert.ToInt16(global.A, 2); //Convert the binary string back to int
            int mNum; //Initialize which value is 'M' going to have

            if (global.wholeString[global.strSize - 2] == '1' && global.wholeString[global.strSize - 1] == '0') //If last bit is 0 and the one before that is one, a subtraction will be executed
            {
                mNum = (int) Math.Pow(2, 4) - Math.Abs(Convert.ToInt16(global.M, 2)); //Get 2's complement of string for easier subtraction
                global.opName = "Subtraction   "; //Determine operation to be performed
                global.cycle = global.cycle.Contains('-') ? "0": global.cycle; //If it's the first cycle, redefine it as 0 because it hasn't been redefined before initializing
            }
            else //If last bit is 1 and the one before that is 0, a sum will be executed
            {
                mNum = Convert.ToInt16(global.M, 2); //Convert string to int
                global.opName = "Addition      "; //Determine operation to be performed
            }
            global.A = Convert.ToString(adderNum + mNum, 2).PadLeft(4, '0'); //Convert 'A' back to binary string, with a length of 4 char's
            trimAdder(); checkOp(); messages.printVar(); //See methods below; print the variables on screen
        }

        public static void checkOp() //If either a subtraction or a sum was done, the cycle stays the same until displacement
        {
            if (global.opName.Contains("Add") || global.opName.Contains("Sub")) //If operation contains code-names, do...
            {
                global.cycle = "  " + (Convert.ToInt16(global.cycle) + 1).ToString(); //Increase cycle until displacement
            }
        }

        public static void trimAdder() //In operations where the adder produces an overflow, trim it and ignore it
        {
            if (global.A.Length > 4) //If length is greater than 4 bits...
                global.A = global.A.Remove(0, 1); //Trim down overflow
        }
    }
}
