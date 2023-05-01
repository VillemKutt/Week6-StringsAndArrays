using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada eesnime
            //programm kuvab kasutaja eesnime pikkust

            Console.WriteLine("Sisesta oma eesnimi;");
            string firstName = Console.ReadLine();

            //int firstNameLength = firstName.Length;
            Console.WriteLine($"Sinu eesnimes on {firstName.Length} sümbolit.");
        }
    }
}
