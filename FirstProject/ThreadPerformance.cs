using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class ThreadPerformance
    {
        // Lets make two methods which count to 1lakh.
        // First we run them using single thread and measure the time
        // Then we run them parallely using two threads and then measure its time

        public static void incrementCounter1()
        {
            long Count1 = 0;
            for(int i = 0; i < 10000000; i++)
            {
                Count1 += 1;   
            }

            Console.WriteLine(Count1);
        }

        public static void incrementCounter2()
        {
            long Count2 = 0;
            for (int i = 0; i < 10000000; i++)
            {
                Count2 += 1;
            }

            Console.WriteLine(Count2);
        }

        static void Main()
        {
            // Lets run above method using single threa and use Stopwatch to count the time

            Stopwatch s1 = new Stopwatch();

            s1.Start();
            incrementCounter1();
            incrementCounter2();
            s1.Stop();

            Console.WriteLine("Total TIme for single threaded counter is :" +s1.ElapsedMilliseconds +" ms");


            // Lets check time is we use multiple threads
            Stopwatch s2 = new Stopwatch();
            Thread t1 = new Thread(incrementCounter1);
            Thread t2 = new Thread(incrementCounter2);

            s2.Start();
            t1.Start();
            t2.Start();
            s2.Stop();

            t1.Join();t2.Join();

            Console.WriteLine("Total TIme for multi threaded counter is : " + s2.ElapsedMilliseconds +"ms");

        }
    }
}

