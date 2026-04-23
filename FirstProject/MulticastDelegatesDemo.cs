using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    // lets define a delegate

    public delegate double AreaAndPerimeterDelegate(double width, double height);
   

    internal class MulticastDelegatesDemo
    {
        double Area(double width,double height)
        {
            double area = width * height;
            Console.WriteLine("Area of Rectangle" + area);

            return area;
        }

        double Perimeter(double width, double height) {

            double perimeter = 2 * (width + height);

            Console.WriteLine("Perimeter of Rectangle" + perimeter);

            return perimeter;
        }

        static void Main()
        {   
            // instance of class
            MulticastDelegatesDemo md = new MulticastDelegatesDemo();

            //Assigning delegate the first method like thiis AreaAndPerimeterDelegate apd = new AreaAndPerimeterDelegate(md.Perimeter);
            // below alos This also works

            AreaAndPerimeterDelegate apd = md.Perimeter;

            //assigning delegate second method

            apd += md.Area;

            // calling the delegates
            apd(2, 5);

            // if the methods have returned then the last methods return is returned

            // Or we can use following way

             List <double> Values = [];

            foreach (AreaAndPerimeterDelegate d in apd.GetInvocationList())
            {
                double res = d(3, 4);
                Values.Add(res);
            }

            Console.WriteLine("values results " + string.Join(", ", Values));
        }
    }
}
