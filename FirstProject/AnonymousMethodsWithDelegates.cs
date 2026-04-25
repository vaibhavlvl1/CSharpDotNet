using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{   

    // declaring a delegate
    delegate string PrintGreetingDelegate(string str);
    internal class AnonymousMethodsWithDelegates
    {
        static void Main()
        {
            // This is a anonymous method directly assigned to a declared printgreetindelegate using keyword delegate 

            PrintGreetingDelegate pd = delegate (string str)
            {
                return "Hello " + str;
            };
        }
    }
}
