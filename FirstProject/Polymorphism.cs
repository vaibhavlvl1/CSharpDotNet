using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class PolymorphismParent
    {
        // make this method as virtual so that it can marked for overiding in child. In child the
        // method to be overridden is marked as override. 
        // If no keywords of virtual or override is used then also it works but it is called method hiding
        // in method hiding we use keyword new when declaring a parent method in child.
        public virtual void ParentClass()
        {
            Console.WriteLine("Parent Class method Called ");
        }
 
        
    }

    class PolymorphismChild : PolymorphismParent
    {
        // uncomment to see overriding in this child
        public override void ParentClass()
        {
            Console.WriteLine("Parent Class modified in Child Class");
        }

        static void Main()
        {
            PolymorphismChild PC = new PolymorphismChild();

            PC.ParentClass();
        }

       

      

    }
}
