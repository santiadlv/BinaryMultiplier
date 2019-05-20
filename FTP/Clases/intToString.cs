using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTP.Clases
{
    class intToString
    {
        public static string NumToS(int num) //User input
        {
            string binNum = ""; //Initialize empty string

            while (num > 1) //While the remainder is more than one, keep appending numbers
            {
                int remainder = num % 2; //Mod of the number
                binNum = Convert.ToString(remainder) + binNum; //Convert it to a string
                num /= 2; //Divide it over 2 to get closer to remainder = 0
            }
            binNum = Convert.ToString(num) + binNum; //Append the last digit, if necessary

            while (binNum.Length < 4) //Append 0's to the left if binary string is too short (isn't 4 char's)
            {
                binNum = binNum.PadLeft(4, '0');
            }

            return binNum; //Return binary string
        }
    }
}
