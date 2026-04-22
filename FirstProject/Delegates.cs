using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{

    //delegate
    public delegate void MultiplyDelegate(int a, int b);
    public delegate void PrintNameDelegate(string s);


    internal class DelegatesDemo
    {
        // Declaring some methods and thie calls then declaring a delegate and how to call it

        // Non static method
        public void Add(int a, int b)
        {
            Console.WriteLine("Non Static Method called " + a + b);
        }


        // static method
        public static void Hello(string name)
        {
            Console.WriteLine("Static Method Called " + name);
        }

      // check the delegate declared in namespace and see hows its used in main below


        static void Main()
        {
            // non static methods cannot be directly used in static methods. need to create instance

            DelegatesDemo D = new DelegatesDemo();

            D.Add(1, 2);

            //static methods can be direclty called

            Hello("Ehe");

            // Now we use Delegates we create instance of it here.  its reference type
            // Then pass the method in the delegate

            MultiplyDelegate md = new MultiplyDelegate(D.Add);
            // use the delegate
            md(4, 5);

            // another delegate to print name

            PrintNameDelegate pd = new PrintNameDelegate(Hello);

            pd("Vaibhav");

            // can be used as folloows as well
            pd.Invoke("Freiren");
            


        }


    }
}
