using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.Interfaces
{
     interface ITestInterface1
    {
         void  Add(int a, int b);
         void Sub(int a, int b);
    }

    // Interfaces can be seperate or can inhereit from each other
    interface ITestInterface2
    {
        void Mul(int a, int b);
        void Div(string a, string b);
    }

    // interface that inherits from both the above . Only interfaces supporr multiple inheritance. clases do not
    // because if method names are same. then child wont know which method is consumed by which parent class.
    // interfaces just wants that their child should implement parents method and not consume them.

    interface ITestMultiInheritedInterface : ITestInterface1, ITestInterface2
    {
        void Show(int a, int b);
        void Hide(int a, int b);
    }
}
