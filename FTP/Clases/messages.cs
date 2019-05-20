using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTP.Clases
{
    class messages
    {
        public static void welcome() //Starting message with a few instructions
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Welcome to the signed binary multiplier. Please follow the instructions on screen.");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Be aware that in order for the program to work properly, you must enter a number between -7 and 7.\n");
            Console.ResetColor();
            Console.WriteLine("=================================================================================================\n");
        }

        public static void initVar() //Initialize the data columns
        {
            Console.WriteLine("\n\n  A        Q      Q-1     M          Process         Cycle");
        }

        public static void printVar() //Print the values of each variable for each cycle completed
        {
            Console.WriteLine(" {0}     {1}     {2}     {3}     {4}     {5}\n", global.A, global.Q, global.Q_1, global.M, global.opName, global.cycle);
        }

        public static void separator() //Separate the values for easier comprehension
        {
            Console.WriteLine("--------------------------------------------------------------\n");
        }

        public static void displayResult() //Display the result of the multiplication
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\nThe result of the multiplication of {0} by {1} is: ", global.intQ, global.intM);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0} ({1} in decimal notation).", String.Concat(global.A, global.Q), (global.intQ * global.intM).ToString());
            Console.ResetColor();
        }

        public static void compNote() //Note displayed if the number multiplied involved a negative sign
        {
            Console.WriteLine("Note: the result must be converted to 2's Complement to show its real absolute value.");
        }

        public static void errorMsg() //Message displayed if user enters wrong data type of out of range input
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\nYou entered something other than a signed integer, or an out of range number (-7 to 7).\nPlease try again by pushing any button.");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
