﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontPanic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //programm asendab kõik 'o' tähed lauses "Don't panic" nulliga - 0;
            //programm asendab kõik 'a'tähed lauses number 4-ga;


            string dontP = "Don't panic";

            dontP = dontP.Replace('o', '0');

            dontP = dontP.Replace('a', '4');

            Console.WriteLine(dontP);
        }
    }
}
