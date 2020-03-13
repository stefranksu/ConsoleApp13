using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            var version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            Console.WriteLine(version); // -> "1.1.2.10"

            //var assemblyLocation = System.Reflection.Assembly.GetExecutingAssembly().Location;
            //var fileVersion = System.Diagnostics.FileVersionInfo.GetVersionInfo(assemblyLocation).FileVersion;
            //Console.WriteLine(fileVersion); // -> "1.2.32.2"

            //var assemblyLocation = System.Reflection.Assembly.GetExecutingAssembly().Location;
            //var version = System.Diagnostics.FileVersionInfo.GetVersionInfo(assemblyLocation).ProductVersion;
            //Console.WriteLine(version); // -> "1.2.32-alpha-01"


        }
    }
}
