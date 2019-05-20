using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTP.Clases
{
    class numConversion
    {
        public static void convMultiplicand() //Get multiplicand
        {
            try
            {
                Console.Write("\nEnter the multiplicand of the operation: ");
                global.Q = Console.ReadLine();
                global.intQ = Convert.ToInt16(global.Q); //Convert user input to int

                if (global.intQ > 7 || global.intQ < -7) //If out of range, display error message
                {
                    messages.errorMsg(); //Error message
                    convMultiplicand(); //Run the method again to get a proper number to multiply
                }

                global.negQ = global.intQ < 0 ? true : false; //Determine sign for posterior usage
                global.Q = binaryConversion.binConversion(global.intQ); //Convert the input number to binary
            }
            catch //If data type is incorrect
            {
                messages.errorMsg(); //Error message
                convMultiplicand(); //Run the method again to get a proper number to multiply
            }
        }

        public static void convMultiplier() //Get multiplier
        {
            try
            {
                Console.Write("\nEnter the multiplier of the operation: ");
                global.M = Console.ReadLine();
                global.intM = Convert.ToInt16(global.M); //Convert user input to int

                if (global.intM > 7 || global.intM < -7) //If out of range, display error message
                {
                    messages.errorMsg();
                    convMultiplier();
                }

                global.negM = global.intM < 0 ? true : false; //Determine sign for posterior usage
                global.M = binaryConversion.binConversion(global.intM); //Convert the input number to binary
            }
            catch //If data type is incorrect
            {
                messages.errorMsg(); //Error message
                convMultiplier(); //Run the method again to get a proper number to multiply
            }
        }

        public static void checkSign() //Check whether any negative sign was involved; if so, show note asking to complement
        {
            if (global.negM == true || global.negQ == true)
            {
                if ((global.negM == true && global.negQ == true) == false)
                {
                    messages.compNote();
                }
            }
        }
    }
}
