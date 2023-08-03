using System.Runtime.CompilerServices;

namespace circleClass
{
    internal class Program
    {
        public static double radius { get; private set; }

        //  class creation
        public class Circle
        {
            public double Radius;
            public Circle(double radius)
            { 
               Radius = radius;
            }
            public double getArea()
            {
                double area =  Math.PI * Math.Pow(Radius, 2);
                return area;
            }
             public double GetCircumference()
            {
                double Circumference = Math.PI * Radius * 2;
                return Circumference;
            }

        }
        static void Main(string[] args)
        {
            Console.Write("Enter the Radius :");
            int radius = Convert.ToInt32(Console.ReadLine());
            Circle circle = new Circle(radius);
            double area = circle.getArea();
            Console.WriteLine( "Area : " + area );
            double circumference = circle.GetCircumference();
            Console.WriteLine( "Circumference :" + circumference );
        }
    }
}