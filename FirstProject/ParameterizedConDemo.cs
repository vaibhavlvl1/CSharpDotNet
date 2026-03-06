using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class ParameterizedConDemo
    {   
        // This value of x will be initialized in constructors as 0 unless changed in construcotrs
        int x;
        public ParameterizedConDemo(int i) {
            Console.WriteLine("Parameterized Construcotr called with value of I " + i);
            x = i;
        }

        public void Display()
        {
            Console.WriteLine("The Value of X is " + x);
        }

        static void Main()
        {
            ParameterizedConDemo pcd1 = new ParameterizedConDemo(10);
            ParameterizedConDemo pcd2 = new ParameterizedConDemo(12);

            pcd1.Display();
            pcd2.Display();
        }
    }
}
