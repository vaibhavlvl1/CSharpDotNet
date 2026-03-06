using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class CopyConDemo
    {
        int x;

        // the main objective here is to make a constructor which will keep the values of the variables same .

        // constructor one ---> parameterized
        public CopyConDemo(int i)
        {
            Console.WriteLine("Constructor one called ");
            Console.WriteLine("The Value of I is: " + i);
            x = i;
        }

        // constru0ctor two ---> copy constructor

        public CopyConDemo(CopyConDemo obj)
        {
            Console.WriteLine("Constructor two called ");
            x = obj.x;
        }

        public void Display()
        {
            Console.WriteLine("The Value of X is :" + x);
        }
        static void Main()
        {   
            // construcotr 1 called
            CopyConDemo ccd1 = new CopyConDemo(10);

            // construcotr two called with previous instance of class so the values of above class are kept
            CopyConDemo ccd2 = new CopyConDemo(ccd1);

            ccd1.Display();
            ccd2.Display();
        }
    }
}
