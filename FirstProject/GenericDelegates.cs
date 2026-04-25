using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{   
    internal class GenericDelegates
    {
        //lets define three methods to use generic delegates with

        double AddNums(int a, float b ,double c) {
            return a + b + c;
        }

        void AddNums2(double a, double b) {
            Console.WriteLine("The Addtion of Numbers is "+ a+b);
        }

        bool AddNums3(string str)
        {
            if (str.Length > 5) { return true; }
            else return false;
        }


        static void Main()
        {
            GenericDelegates gd = new GenericDelegates();

            // lets invoke these methods using generic delegates

            // function 1
            Func<int, float, double, double> Obj1 = gd.AddNums;

            double result = Obj1.Invoke(1, 2.4f, 3.44);

            Console.WriteLine("Result of first method with func delegate " + result);

            // function 2
            // since this generic delegate is used in void return type no need to mention in <>
            Action<double, double> Obj2 = gd.AddNums2;

            Obj2.Invoke(2.1,4.1);


            //function 3
            // since this generic delegate is used in bool return type no need to mention in <>
            Predicate<string> Obj3 = gd.AddNums3;

            Boolean result1 = Obj3.Invoke("Vaibhav");

            Console.WriteLine("THis is when tird delegate invokes a method " + result1);

            // We can further remove the methods and use lambda functions here



        }
        
    }
}
