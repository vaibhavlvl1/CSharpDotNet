using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class ThreadTest2
    {
        // This file will teach joining of threads
        // Inner threads are joined so that outer main thread doesnt exit before inner thread exits

        static void Test()
        {
            Console.WriteLine("Thread 1 Start");
            for(int i = 0; i < 50; i++)
            {
                Console.WriteLine("Test 1 at " + i);
            }
            Console.WriteLine("Thread 1 End");
        }

        static void Test2()
        {
            Console.WriteLine("Thread 2 Start");
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Test 2 at " + i);
            }
            Console.WriteLine("Thread 2 End");
        }

        static void Test3()
        {
            Console.WriteLine("Thread 3 Start");
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Test 3 at " + i);
            }
            Console.WriteLine("Thread 3 End");
        }


        static void Main()
        {
            Console.WriteLine("Main Thread Starts");
            
            // Creating Threads for the tests

            Thread t1 = new Thread(Test);
            Thread t2 = new Thread(Test2);
            Thread t3 = new Thread(Test3);

            // Starting Threads
            t1.Start();t2.Start();t3.Start();

            t1.Join();t2.Join();t3.Join();   // Comment this to see logs and sequence of execution. Youll see the main thread ends way early than other childs thread


            Console.WriteLine("Main Thread Ends");

        }
    }
}
