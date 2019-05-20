using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTP.Clases
{
    class masterControl
    {
        public static int counter = 1;
        public static void multiply()
        {
            var GV = new global(); //Initialize global variables
            Console.WriteLine();
            messages.welcome();
            numConversion.convMultiplicand(); //Get first number, convert it to binary string
            numConversion.convMultiplier();   //Get second number, convert it to binary string
            messages.initVar(); messages.separator(); messages.printVar(); messages.separator(); //Make it look beautiful

            for (int i = counter; i < 5; i++) //Run the loop 4 times, one for each cycle needed to complete the operation
            {
                comparer.compareIndexes(global.Q); //Compare Q and Q-1 to see if a sum or subtraction must be done, otherwise only displacement will happen
                splitter.split(global.wholeString); //Split the result string into smaller substrings to make it more intuitive
                global.cycle = "  " + counter.ToString(); //Increment the cycle number
                messages.printVar(); //Print the variables on screen
                counter++; //Up the counter so the for loop can continue
                if (i != counter)
                    messages.separator(); //If the counter ain't equal to i, separate the result between cycles
            }

            messages.displayResult(); //Display the result of the operation
            numConversion.checkSign(); //Check if the result is negative; in which case, show a message stating that you need to 
                                       //complement the result for it to be understandable by us humans
        }
    }
}
