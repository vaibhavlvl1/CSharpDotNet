using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class CustomApplicationExceptionThrow
    {   
        
        static void Main()

        {
            // *********** Way 1 ******************************************************************
            // ************************************************************************************

            Console.WriteLine("Entering B as a odd Number will throw a Custom Application Exception");
            try
            {
                Console.Write("Enter A: ");
                int A = int.Parse(Console.ReadLine());
                Console.Write("Enter B: ");
                int B = int.Parse(Console.ReadLine());

                if(B%2 > 0)
                {   
                    // throw error here and catch it in catch block
                    throw new ApplicationException("Not Allowed to divide by odd by developer");
                }
            }

            catch (ApplicationException ae)
            {
                Console.WriteLine("Error caught in Catch "+ ae.Message);
            }


            // ******************  Way 2 *************************************************
            // ***************************************************************************

            try
            {
                Console.WriteLine("This via a custom error class");

                Console.Write("Enter C Number :");
                int C = int.Parse(Console.ReadLine());

                if (C%2 > 0)
                {
                    throw new DivideByOddNoException();
                }

            }
            catch (DivideByOddNoException DE)
            {
                Console.WriteLine(DE.Message);
            }

        }

        // ************************* needed for way 2****************************************************
        // ************************************************************************************

        // Lets make a custom exception class and use it
        // We can make another file for class but for simplicity lets declare it here only

        public class DivideByOddNoException : ApplicationException
        {
            // We know that this class has property called  message is defined as vritual in parent so we can edit its message usong overide
            public override string Message
            {
                get
                {
                    return "Not Allowed to Divide By Odd from Custom ex Class";
                }
            }
        }




        
    }
}
