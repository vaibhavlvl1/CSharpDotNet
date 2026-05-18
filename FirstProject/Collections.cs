using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class Collections
    {
        static void Main()
        {   // Non generic or older collections no longer used

            //############################ 1.ArrayList -###################################################
            //#############################################################################################


            // Its size increases by 4 whenerever it gets full. Initially has zero size then becomes 4 when 1 element is added. When 5th element is added its capacity becomes 8
            ArrayList al = new ArrayList();  // Default Capacity is 4 and it will double if more elements get added. we can change default capacity in declaration ArrayList al = new ArrayList(10);
            Console.WriteLine("------------------------- Non Generic --------------------------------------");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("------------------------- 1.ArrayList --------------------------------------"); // Replced by List in generics
            Console.WriteLine("Capacity Before: " + al.Capacity);

            // Adding items to arralist
            al.Add(100);
            al.Add("Hello");
            al.Add("I am");
            al.Add("Vaibhav");
            al.Add(3.44);
            al.Add(45);
            al.Add(46);

            // insert elements in middle of arraylist. inserts element before index mentioned.
            al.Insert(4, "Sutar");

            //remove element
            al.Remove(100); // directly mention the element to remove

            al.RemoveAt(3); // Directly mention the index at which to remove

            Console.Write("Printing ArrayList: [");

            //Print the collection
            foreach (var item in al)
            {
                Console.Write(item + ",");
            };
            Console.WriteLine("]");
            Console.WriteLine("Capacity After: " + al.Capacity);



            // ################################ 2. Hashtable ##############################################
            // ############################################################################################

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("------------------------- 2.Hashtable--------------------------------------");

            Hashtable ht = new Hashtable();

            // Adding Data to hashtable

            ht.Add("Name", "Vaibhav");
            ht.Add("Age", 30);
            ht.Add("Phone", 9021122180);
            ht.Add("Designation", "FrontEndDeveloper");
            ht.Add("Address", "KP,H,Pune,MH,IND");

            //Modifying Data

            ht["Name"] = "Sayali";

            //Printing Data

            foreach (object key in ht.Keys)
            {
                Console.WriteLine(key + " " + ht[key] + " " + key.GetHashCode());
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("------------------------- Generic --------------------------------------");
            Console.WriteLine();

            Console.WriteLine("------------------------- 1.List --------------------------------------");


            //Creating a list of integers

            List<int> li = new List<int>();

            //Adding items
            li.Add(10); li.Add(20); li.Add(30); li.Add(40); li.Add(60); li.Add(70);

            // Inserting items

            li.Insert(4, 50); // index where to insert and item 
            li.Add(80);

            //Removing items
            li.Remove(6);

            // print list 
            foreach (int i in li)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            // We can take any object as input type suppoewe we want a list of customers

            List<CustomerDemo>  Customers = new List<CustomerDemo>();
            // This list will contain all the instances of customers
            CustomerDemo c1 = new CustomerDemo { CustId = 1,Balance=25000,City="Pune",Name="Vaibhav"};
            CustomerDemo c2 = new CustomerDemo { CustId = 2,Balance=35000,City="Pune",Name="Vaibhavi"};
            CustomerDemo c3 = new CustomerDemo { CustId = 3,Balance=45000,City="Pune",Name="Sayali"};

            // add those instance to Customers list
            Customers.Add(c1);
            Customers.Add(c2);
            Customers.Add(c3);

            // To print those customer names values
            foreach(CustomerDemo item in Customers)
            {
                Console.WriteLine(item.Name);
            }


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("------------------------- 2. Dictionary --------------------------------------");


            Dictionary<string, object> d = new Dictionary<string, object>();

            // Adding values to dictionaary
            d.Add("Name", "Vaibhav");
            d.Add("Age", 30);
            d.Add("Phone", 9021122180);
            d.Add("Designation", "FrontEndDeveloper");
            d.Add("Address", "KP,H,Pune,MH,IND");

            // can also add by
            d["Status"] = "Single";
            // updateing values
            d["Name"] = "Vaibhav Str";

            foreach(string key in d.Keys)
            {
                Console.WriteLine(key +" : " + d[key]);
            }







            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("------------------------- Generic Functions --------------------------------------");


            // Usage of Generics functions described below

            bool result = Compare2<int>(5, 10);
            bool result2 = Compare2<string>("ehe", "ehe");
            bool result3 = Compare2<float>(1.4f, 1.41f);

            Console.Write("Generic function results for same functino with different types " + result + " " + result2 + " " + result3 + " ");





        }









        // Generics - 

        // Suppose we have a compare function and we want to compare any a,b  with same types. Then we would have to make many funcitons
        // But generics we can specify the type of a,b in the function itself example
        public static bool Compare(int a, int b)
        {
            return a.Equals(b);
        }

        public static bool Compare2<T>(T a, T b)
        {
            return a.Equals(b);
        }

        // The above function can take any a,b of any types . They would have same types will be compared
        // usage


        // above apporach works well if there is no processing of a,b involved if processing of a,b is involved then it will threw error

        //example uncomment to see

        //public static void Add<T>(T a, T b)
        //{
        //    Console.Write(a + b); // will give error of cant add a and b of type T
        //}

        // To tackle above issue we can use a keyword called dynamic introduced in c# 4.0


        public static void Add<T>(T a, T b)
        {

            dynamic d1 = a;
            dynamic d2 = b;

            Console.Write(d1 + d2); // will give error of cant add a and b of type T
        }

        // Or we can use it as a return type as well

        public static dynamic Mul<T>(T a, T b)
        {

            dynamic d1 = a;
            dynamic d2 = b;

            return d1 + d2;
        }

    }

    
}
