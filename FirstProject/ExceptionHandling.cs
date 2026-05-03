using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class ExceptionHandling
    {

        static void Main()
        {
            // enclose all error causing possibility lines in try catch block ex

            int A = 0; int B = 0; int Z = 0;


            try
            {
                Console.Write("Enter Value of A : ");
                A = int.Parse(Console.ReadLine());
                Console.Write("Enter Value of B : ");
                B = int.Parse(Console.ReadLine());

                if (B == 1)
                {
                    return;
                }

                Z = A / B;

                Console.WriteLine(Z);


            }

            // We can capture specific errors by if we want to perform diffrent corrective actions for differenct errors
            catch (DivideByZeroException ex1)
            {
                Console.WriteLine("Are You stupid wdh would you divide by 0 ffs " + ex1.Message);
            }


            // and we can catch all the remaining exceptions from above
            catch (Exception ex)
            {
                Console.WriteLine("Some Error Occured " + ex.Message + "A: " + A + "B: " + B);
            }

            finally
            {
                Console.WriteLine("This gets executed even if error occurs or it doesnt ");
            }

            // Using Try Catch Makes sure program doesnt get terminated when error occurs and following line gets printed

            Console.WriteLine("End of Program");


            // Note - Whats the need for finally if end of program also get executed if error or no error ?
            // Because ex if B==1 the control will jump but finally will get excuted before returning and end of program wont
            // You cannot escape finally if execution reaches in try block
        }
    }
}
