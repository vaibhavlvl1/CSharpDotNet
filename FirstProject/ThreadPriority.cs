using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class ThreadPriority
    {
        int count1 = 0;
        int count2 = 0;
        public void Test1()
        {
            while (true)
            {
                count1 += 1;
            }

        }

        public void Test2()
        {
            while (true)
            {
                count2 += 1;
            }

        }

        static void Main()
        {
            Console.WriteLine("Main Thread Started");
            ThreadPriority tp = new ThreadPriority();

            Thread t1 = new Thread(tp.Test1); // Normal Priority
            Thread t2 = new Thread(tp.Test2); // Normal Priority

            t1.Start(); t2.Start();

            Console.WriteLine("Putting Main thread to sleep");

            Thread.Sleep(5000);

            Console.WriteLine("Main Thread Awoke");

            t1.Abort(); t2.Abort();

            t1.Join(); t2.Join();

            Console.Write("High Priority Count 1: " + tp.count1 + "Normal Priority Count 2: " + tp.count2);
            Console.WriteLine("Main Thread Exited");


        }
    }
}
