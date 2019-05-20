using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTP.Clases
{
    class global //Using global variables because they'll be redefined over and over again
    {
        public static string A; //Adder
        public static string Q; //Multiplicand
        public static string Q_1; //Last index of multiplicand - 1
        public static string M; //Multiplier
        public static string opName; //Name of the operation to be executed
        public static string cycle; //Cycle number
        public static int intQ; //User input for Q, converted to int
        public static int intM; //User input for M, converted to int
        public static string wholeString; //Strings A, Q and Q_1 fused into one
        public static int strSize; //Size of the fused string 
        public static bool negQ; //Sign of Q
        public static bool negM; //Sign of M

        public global() //Initialize global variables
        {
            A = "0000"; //Adder has a value of zero
            Q_1 = "0"; //Q-1 doesn't exist yet, so it's initialized as zero
            opName = "Initialization"; //First process to be executed
            cycle = " --- "; //No cycle at the beginning
            negQ = false; //Assuming 'Q' isn't negative
            negM = false; //Assuming 'M' isn't negative
        }
    }
}
