using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{

    class Class1
    {
        int i;  
        bool b;

        public Class1()
        {
            Console.WriteLine("Contructor Called");
        }
        static void Main(string[] args)
        {
            Class1 c = new Class1();
            Console.WriteLine("Value of i is - " + c.i);
            Console.WriteLine("Value of i is - " + c.b);
            Console.ReadLine();
        }


    }

}