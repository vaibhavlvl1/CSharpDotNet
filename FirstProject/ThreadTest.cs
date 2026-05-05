using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FirstProject
{
    internal class ThreadTest
    {   
        // Lets declare some methods to assign to threads which we will create.
        static void Test1()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Test 1 Running at :" + i + "%   "+" Using t1");
            }
        }

        static void Test2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Test 2 Running at :" + i + "%   " + " Using t2");
            }
        }

        static void Test3(object limit)
            // used object for int because this method is used in ParameterizedThreadDelegate which needs object
        {

            // reconverting object to int
            int maxLimit = Convert.ToInt32(limit);
            for (int i = 0; i < maxLimit; i++)
            {
                Console.WriteLine("Test 3 Running at :" + i + "%   " + " Using t3");
            }
        }


        static void Main()
        {
            // Create a thread using thread class and pass a method in it for execution
            // We can pass the test method in thread in following ways

            // Lets create a threadStart delegate which is declared in Thread class. We then pass method to this delegate
            // This delegate doesnt take any parameters

            ThreadStart delObj = new ThreadStart(Test1);
            // Then use the delegate obj above and pass it in thread below. This is explicit delegate creation. Refer Delegates
            Thread t1 = new Thread(delObj);
            
            // if we direclty pass the method the CLR implicilty makes a delegate and passes the method there.
            Thread t2 = new Thread(Test2);


            // Lets use another delegate which takes a parameter i.e. if method needs a parameter we need to use 
            // threadstartadelegate. Lets use it there
            // But this delegate only accepts object as parameter. so we must make sure that object keyword is use when accepting parameter in method declaration
            // since this delegate only takes object as input. It is not type safe. It will try to run even if we pass a string.

            ParameterizedThreadStart pdelgateObj = new ParameterizedThreadStart(Test3);

            Thread t3 = new Thread(Test3);

            // Lets start these threads 

            
            t1.Start();// using threadStart delegate
            t2.Start();// direct CLR made a delegate implicitly
            t3.Start(75);// used parameterisedThreadStart delegate which only takes an object


        }

    }
}
