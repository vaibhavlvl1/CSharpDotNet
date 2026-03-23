using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class MethodOverloading
    {
        // We can define two methods with same name but should be with different parameters or their types or their
        // order
           
        public void Test()
        {
            Console.WriteLine("first method with name Test() method");
        }

        public void Test(int i) { Console.WriteLine("second method with name Test() with a param i", i); }

        public void Test(string i)
        {
            Console.WriteLine("Third Method with name Test() with string as a param i", i);
        }

        public void Test(string i,int j)
        {
            Console.WriteLine("Fourth Method with name Test() with string i and int j in order");
        }

        public void Test(int j,string i)
        {
            Console.WriteLine("Fourth Method with name Test() with int j and string i in order");
        }

        static void Main()
        {

            MethodOverloading MO = new MethodOverloading();

            MO.Test("5",5);

        }
    }
}
