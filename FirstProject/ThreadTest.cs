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

        static void Test3()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Test 3 Running at :" + i + "%   " + " Using t3");
            }
        }

        static void Test4()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Test 4 Running at :" + i + "%   " + " Using t4");
            }
        }

        static void Main()
        {
            // Create a thread using thread class and pass a method in it for execution

            Thread t1 = new Thread(Test1);
            Thread t2 = new Thread(Test2);
            Thread t3 = new Thread(Test3);

            // Lets start these threads 

            t1.Start();
            t2.Start();
            t3.Start();
        }

    }
}
