using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class Inheritance1Child:Inheritance1
    {
        // uncommnet this child constructor if parents constructor is parameterized.
        // This this will pass
        // parameter to parent class contructor and wont show any error. 
        // The flow of execution is 
        // Child Main method --> Child Constructor --> Parent constructor executed
	// ---> child constrructor executed ---> child main executed.

        //public Inheritance1Child():base(10)
        //{
        //    Console.WriteLine("Child COntructor called ");
        //}
        static void Main()
        {   

            // We can call members of parent class by creating instance of this class which
            // is child class of the parent class
            Inheritance1Child ic = new Inheritance1Child(); // Instance 

            ic.Test1(); // Usage
            ic.Test2();
            ic.Test3();
            ic.Test4();

            // Parent class can never call members of child class. Lets test it by creating a 
            // Parent Variable and then init it with child class then using childs method.
            // Lets see if We can call the parents variable by declaring the parant class variable as
            // referncing the child class.
            // Looks like we cant call Them. eror CS1061 But they wont be allocated separate memory.
            // They will use the same memmory of above instance

            Inheritance1 icReference = ic;

            icReference.Test1();
            icReference.Test2();
            // icReference.Test3(); gives error
        }

        public void Test3()
        {
            Console.WriteLine("This Method is from child ");
        }
        
    }
}
