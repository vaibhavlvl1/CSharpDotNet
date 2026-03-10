using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class StaticConDemo
    {
        static StaticConDemo()
        {
            Console.WriteLine("Static Constructor called without creating an instance of class");
        }

        public static void Main() { }
    }
}
