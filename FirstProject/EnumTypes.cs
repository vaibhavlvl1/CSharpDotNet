using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    // Declared a enum called Days
    public enum Days
    {
        Monday,Tuesday,Wednesday,Thursday,Friday,Saturday
    }

    // They have default values of 0 to 5 .
    // We can set our values to it as well as below


    public enum Days1
    {
        Monday=11, Tuesday=22, Wednesday=33, Thursday=44, Friday=55, Saturday=66
    }

    internal class EnumTypes
    {
        // Method will be used below
        public static Days MeetingDay { get; set; } = (Days)1;
        static void Main()
        {   

            // Using enum Days

            Days d = 0;
            Console.WriteLine(d);
            // this will print monday
            //only fisrt value can be taken this way. We cannot use Days d = 1;
            //for other values format is as follows

             d = (Days)1;
            Console.WriteLine(d);

            d = (Days)5;
            Console.WriteLine(d);

            d = Days.Saturday;
            Console.WriteLine((int)d); 


            //Console.BackgroundColor = ConsoleColor.Red;

            // Here ConsoleColor is the Enum Type

            // for days 2

            foreach (int i in Enum.GetValues(typeof(Days1)))
            {
                Console.WriteLine(i);
            }

            foreach (string i in Enum.GetNames(typeof(Days1)))
            {
                Console.WriteLine(i);
            };

            // actual usage How its meant to be used

            MeetingDay = (Days)3;

            Console.WriteLine(MeetingDay);

            MeetingDay = Days.Monday;

            Console.WriteLine(MeetingDay);
            
        }
    }
}

