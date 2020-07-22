using System;

namespace Delegates
{
    class Program
    {

        public delegate void circle(double r);


        public void circlearea(double r)
        {
            Console.WriteLine( " Area of Circle" + (3.14)*r*r);
        }
        public void circlePerameter(double r)
        {
            Console.WriteLine(" Perameter of Circle" + 2*(3.14) * r);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Program obj = new Program();

            circle c = new circle(obj.circlearea);
            circle c1 = new circle(obj.circlePerameter);
            c(4.2);
            c1(4.2);
        }
    }
}
