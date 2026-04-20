using System;
using System.Collections.Generic;
using System.Text;

namespace IndexersDemoProject
{
    internal class Indexer
    {
        static void Main()
        {
            Employee E = new Employee(1,"Jason","USA","Illinois","Head of Strss",900000);

            // Inddexers has been defined in the class Employtee check it out

            Console.WriteLine(E[0]);
            Console.WriteLine(E[1]);
            Console.WriteLine(E[2]);
            Console.WriteLine(E[3]);
            Console.WriteLine(E[4]);

            //setting some random values to the varibles using the indexers

            E[0] = 555;
            E[1] = "Statham";
            E[2] = "Iceland";

            Console.WriteLine(E[0]);
            Console.WriteLine(E[1]);
            Console.WriteLine(E[2]);
            Console.WriteLine(E[3]);
            Console.WriteLine(E[4]);

        }
    }
}
