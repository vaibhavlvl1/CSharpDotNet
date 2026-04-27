using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsProject
{
    internal static class NewMethods
    {

        // These are new methods declared
        // We pass this Program which will tell c# that This methods belongs to Program. 
        // If you miss this. then it will convey that this new method takes program as parameter
        // so using this is compulsary

        // You must be wondering then why they are called using instance in ProgramInstance.cs file ?
        // Thats because when these methods are bound to a class/structure they become nonstatic again. so they are called by instance

        public static void NewMethod(this Program p)
        {
            Console.WriteLine("New Method 1");
        }

        public static void NewMethod2(this Program p, int i) 
        {
            Console.WriteLine("New Metjod 2");
        }

        // Let us add a Factorial method to the int structure. right click on int type and go to its 
        // definition it will show its type as structure and name as int32

        public static long Factorial(this Int32 x)
        {
            long factorial = 1;

            for (int i = 1; i <= x; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        //lets make a method which will convert the given string to proper case which is not currently present.
        // String class is sealed class. Means it cannot be inherited. it can only be instantiated.


        public static string ProperCase(this String str) 
        {
            if (str == null || str == "")
            {
                return str;
            }

            str = str.ToLower();

            string[] strArray = str.Split(" ");

            string newString = null;

            foreach (string word in strArray)
            {   
                //split into character array
                char[] carr = word.ToCharArray();
                //upper case the first word
                carr[0] = Char.ToUpper(carr[0]);

                if( newString == null)
                {
                    newString = new String(carr);
                }
                else
                {
                    newString += " " + new string(carr);
                }
            }

            return newString;

        }
    }
}
