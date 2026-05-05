using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class ThreadLocking
    {
        public void SayHello()
        {
            Console.Write("Hello How are you ");

            Thread.Sleep(2000); // To simulate api respose delay

            Console.WriteLine(" Vaibhav");
        }

        public void SayHelloAgain()
        { // Thread locking active
            lock (this)
            {
                Console.Write("Hello How are you ");

                Thread.Sleep(2000); // To simulate api respose delay

                Console.WriteLine(" Vaibhavi");
            }
        }


        static void Main()
        {
            ThreadLocking th = new ThreadLocking();

            Thread t1 =  new Thread(th.SayHello);
            Thread t2 =  new Thread(th.SayHello);
            Console.WriteLine("Wothout Threadlocking");
            //starting single thread flawless output
            //t1.Start();

            //Starting another thread will cause jumbled output
            //t2.Start();


            // Now we use another method with thread locking which will display flawless output for many threads ran simultaneiusly
            Console.WriteLine("With Threadlocking");

            Thread t3 = new Thread(th.SayHelloAgain);
            Thread t4 = new Thread(th.SayHelloAgain);

            t3.Start();
            t4.Start();
        }
    }
}
