using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTP.Clases
{
    class binaryConversion
    {
        public static string binConversion (int x) //User input
        {
            string convertedNum;

            if (x < 0) //Check if number is negative
            {
                int y = (int) Math.Pow(2, 4) - Math.Abs(x); //Get 2's complement
                convertedNum = intToString.NumToS(y); //Send it to another method to get binary string
            }
            else if (x > 0) //Check if number is positive
            {
                convertedNum = intToString.NumToS(x); //Send it to another method to get binary string
            }
            else //If number is 0, get the direct binary string
            {
                convertedNum = "0000";
            }

            return convertedNum; //Return the binary string of the number
        }
    }
}