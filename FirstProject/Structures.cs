using System;
using System.ComponentModel.DataAnnotations;

namespace FirstProject
{
    struct SimpleStructure
    {
        int i;  // cant assign the value direclty beacise it wont be initialized cause instance not created by new keyword
        public void Display()
        {
            Console.WriteLine("Method in a struct "+ i);
        }

        static void Main()
        {       
            // Note i am not crerating an instance with new keyword to access the method. It can be used .
            // IT is optional 

            SimpleStructure SS; // No new keyword
            SS.i = 25; // have to initailized variables like this because new keyword not used.
            SS.Display();
        }
    }
}