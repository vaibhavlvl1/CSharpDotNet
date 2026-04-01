using FirstProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{   

    // This child is inhrerits from interface 1 and implements the methods Add and Sub . Public is used
    // before the method name. And this is called normal implemention. It may cause ambiguity if names of methods are same. MAY CAUSE
    // If both the interfaces have method with same name and both throw error. then using it once solves the error. as
    // interfaces think their method has been implemented
    public class InterfaceChild1:ITestInterface1,ITestInterface2
    {
        public void Add(int a,int b)
        {
          Console.WriteLine(a + ", " + b);
        }


        public void Sub(int a, int b)
        {
            Console.WriteLine(a + ", " + b);
        }

        public void Mul(int a, int b)
        {
            Console.WriteLine(a + ", " + b);
        }


        public void Div(string a, string b)
        {
            Console.WriteLine(a + ", " + b);
        }

    }

    // This is another class implementing the other interface methods explicitly using interface names.
    // This solves the ambiguity problem
    public class InterfaceChild2 : ITestInterface2
    {
        void ITestInterface2.Div(string a, string b)
        {
            throw new NotImplementedException();
        }

        void ITestInterface2.Mul(int a, int b)
        {
            throw new NotImplementedException();
        }
    }


    public class InterfaceChild3 : ITestInterface1,ITestInterface2
    {
        void ITestInterface2.Div(string a, string b)
        {
            throw new NotImplementedException();
        }

        void ITestInterface2.Mul(int a, int b)
        {
            throw new NotImplementedException();
        }

        void ITestInterface1.Add(int a, int b)
        {
            throw new NotImplementedException();
        }

        void ITestInterface1.Sub(int a, int b)
        {
            throw new NotImplementedException();
        }
    }


    internal class InterfaceChildClass
    {
    }
}
