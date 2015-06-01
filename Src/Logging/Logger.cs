using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging
{
    public class Logger
    {

        public static string Log(string message)
        {
            string logString = string.Format("LOG: {0}", message);
            Console.WriteLine(logString);
            return logString;
        }

    }
}
