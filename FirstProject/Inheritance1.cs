using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class Inheritance1
    {
// uncomment the followinf constructor if you want to see what happens of constructor
// with parameters is called from child class. You have to use base 10 in in child class
// constructor. this 10 is the value it passes to this int i. Then this constructor
// gets executed then child constructor gets executed then childs main method.

        //public Inheritance1(int i)
        //{
        //    Console.WriteLine("Parameteriozed constrtuctor called with value", i);
        //}

        static void Main(string[] args)
        {

        }
        public void Test1()
        {
            Console.WriteLine("This is from parent class");
        }

        public void Test2()
        {
            Console.WriteLine("This is also from parent");
        }

        // uncomment the paramerterized constructor to use this test in child class
        public void Test4()
        {
            Console.WriteLine("This is also from parent");
        }
    }
}
