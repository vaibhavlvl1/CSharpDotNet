using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class ExplicitConDemo
    {
        // The following is an explicit constructor because it is defined. It may be parameterless or parameterised.
        // This constructor is called every time a new instance of class is created.

        public ExplicitConDemo()
        {
            Console.WriteLine("Constructor has been called");
            int I;
            bool B;
        }


        static void Main()
        {
            ExplicitConDemo obj1 = new ExplicitConDemo();
            // we are explicitly calling the constructor . If you hover in ExplicitConDemo() youll see ExplicitConDemo.ExplicitConDemo(). 
            //The second one is constructor. Here we call the explicit constructor defined above
            ExplicitConDemo obj2 = new ExplicitConDemo();
            ExplicitConDemo obj3 = new ExplicitConDemo();



        }
    }
}
