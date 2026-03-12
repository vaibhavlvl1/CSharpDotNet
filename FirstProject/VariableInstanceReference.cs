using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class VariableInstanceReference
    {
        int X;
        static void Main()
        {
            // Variable of class

            VariableInstanceReference VIR1; // variable of class VariableInstanceReference

            VariableInstanceReference VIR2 = new VariableInstanceReference(); // instance of class VariableInstanceReference
    

            VariableInstanceReference VIR3 = VIR2; //Now VIR1 is a reference of class VIR2

            VariableInstanceReference VIR4 = new VariableInstanceReference(); // new instance

            Console.WriteLine(VIR2.X); // prints 0 also the reference VIR3.X is now 0;

            VIR4.X = 100;
            Console.WriteLine(VIR4.X); // prints 100 VIR3X and VIR2.X are still 0;
        }
    }
}
