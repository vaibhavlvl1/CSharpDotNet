using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsProject
{
    internal class ProgramInstance
    {
        static void Main() 
        {
            Program pi = new Program();

            pi.OldMethod1();

            pi.NewMethod();

            // Lets call the factorial method that we defined and binded to structure int

            int x = 5;

            Console.WriteLine("The factorial of "+x + " is "+x.Factorial());

            // lets call the to proper case method that we defined and binded to sealed class string

            string str = "HellO I MY nAme is vAiBhAV";

            Console.WriteLine(str.ProperCase());
        }
    }
}
