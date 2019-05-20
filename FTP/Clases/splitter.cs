using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTP.Clases
{
    class splitter
    {
        public static void split(string wS) //Split the fused string back into its original components
        {
            global.A = wS.Substring(0, 4); //First 4 char's comprise 'A'
            global.Q = wS.Substring(4, 4); //The next 4 char's comprise 'Q'
            global.Q_1 = wS.Substring(8, 1); //Final char is 'Q-1'
        }
    }
}
