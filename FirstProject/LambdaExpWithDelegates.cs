using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{

    internal class LambdaExpWithDelegates
    {
        delegate void GreetDelegate(string str);
        static void Main()
        {
           
            // we now assign a lambda function to the delegate 
            // Notice we dont write return type or delegate keyword as compared to anonymous function
            GreetDelegate pd = (name) => { Console.WriteLine( "Hello " + name + "Ohayo"); };

            pd("Vaibhav");
        }
    }

}