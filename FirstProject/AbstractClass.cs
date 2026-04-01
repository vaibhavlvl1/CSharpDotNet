using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{

    // note the abstract keyword use here
    public abstract class Figure
    {
        public double Width, Height, Radius;
        public float PI = 3.147f;

        public abstract double GetArea();
    }

    class Rectangle : Figure
    {
        public Rectangle(double Height, Double Width)
        {
            this.Width = Width;
            this.Height = Height;
        }

        public override double GetArea() {
            return this.Width * this.Height;
        }
    }

    class Circle : Figure
    {
        public Circle(double Radius)
        {
            this.Radius = Radius;
        }

        public override double GetArea() {
            return this.Radius * this.Radius * this.PI;
        }

    }

    class Cone : Figure
    {
        public Cone(double Radius, double Height)
        {
            this.Radius = Radius;
            this.Height = Height;

        }

        public override double GetArea() {
            return this.PI * this.Radius * this.Height;
        }
    }

    internal class AbstractClass
    {
        static void Main()
        {
            Rectangle R = new Rectangle(5, 2);
            Console.WriteLine("Area of Rectangle " + R.GetArea() + " Units^2");

            Circle C = new Circle(5);
            Console.WriteLine("Area of Circle " + C.GetArea() + " Units^2");

            Cone CN = new Cone(5,10);
            Console.WriteLine("Area of Cone " + CN.GetArea() + " Units^2");
        }
    }
}
