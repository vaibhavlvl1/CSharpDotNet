using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class Collections
    {
        static void Main()
        {   // Non generic or older collections no longer used
            // 1.ArrayList - 
            // Its size increases by 4 whenerever it gets full. Initially has zero size then becomes 4 when 1 element is added. When 5th element is added its capacity becomes 8
            ArrayList al = new ArrayList();  // Default Capacity is 4 and it will double if more elements get added. we can change default capacity in declaration ArrayList al = new ArrayList(10);
            Console.WriteLine("1. ArrayList :");
            Console.WriteLine("Capacity Before: "+ al.Capacity);

            // Adding items to arralist
            al.Add(100);
            al.Add("Hello");
            al.Add("I am");
            al.Add("Vaibhav");
            al.Add(3.44);
            al.Add(45);

            // insert elements in middle of arraylist. inserts element before index mentioned.
            al.Insert(4, "Sutar");

            //remove element
            al.Remove(100); // directly mention the element to remove

            al.RemoveAt(3); // Directly mention the index at which to remove

            Console.Write("Printing ArrayList: [");

            //Print the collection
            foreach (var item in al)
            {
                Console.Write(item+",");
            };
            Console.WriteLine("]");
            Console.WriteLine("Capacity After: "+ al.Capacity);
        }
    }
}
