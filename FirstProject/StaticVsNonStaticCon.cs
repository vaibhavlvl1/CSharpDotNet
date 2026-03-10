using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class StaticVsNonStaticCon
    {
        int X;
        static int Y;
        static StaticVsNonStaticCon()
        {
            Console.WriteLine("Static Construtor Called Only 1 time");
        }

        public StaticVsNonStaticCon()
        {
            Console.WriteLine("Non Static Construcotr gettting called with every created Instance");
        }

        public void Display()
        {
            Console.WriteLine("NS constructor is now called ");
        }

        static void Main()
        {
            // We can directly use value of a static variable in static method in class. because the varaible is initilized single time 
            // by static constructor. But we cant do that to NS variable because it gets initialized with all the instances
            // and concufion ensues which value are we refering to 
            Console.WriteLine(Y);

            StaticVsNonStaticCon NS = new StaticVsNonStaticCon();

            //NS.Display();
        }

      

        

        //NS.Display();

    }
}
