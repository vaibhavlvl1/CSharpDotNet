using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class StringVStringBuilder
    {
        static void Main()
        {   
            // lets use a string and modify it 100 times and log its time
            String str = "Hello";

            // the below string addition will make 100 copies of a string. lets log the time taken for this suign stopwatch class
            Stopwatch sw = new Stopwatch();

            sw.Start();
            for (int i=1;i<= 50000; i++)
            {
                str = str + "1";
            }
            sw.Stop();

            // Now lets use above example using a string builder

            StringBuilder sbString = new StringBuilder();
            sbString.Append("Hello");

            Stopwatch sw1 = new Stopwatch();

            sw1.Start();
            for (int i = 1; i <= 50000; i++)
            {
                sbString.Append("1");
            }
            sw1.Stop();

            Console.WriteLine("Operation on String took " + sw.ElapsedMilliseconds);
            Console.WriteLine("Operation on String builder took " + sw1.ElapsedMilliseconds);
            
        }
    }
}
