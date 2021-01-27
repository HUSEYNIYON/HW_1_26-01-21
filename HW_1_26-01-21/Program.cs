using System;

namespace HW_1_26_01_21
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstSide = Convert.ToDouble(Console.ReadLine());
            double secondSide = Convert.ToDouble(Console.ReadLine());
            var rect = new Rectangle(firstSide, secondSide);
            Console.WriteLine($"Area = {rect.AreaCalculator()}");
            Console.WriteLine($"")
            
        }
    }
    class Rectangle
    {
        public double firstSide { get; set; }
        public double secondSide { get; set; }
        public Rectangle(double FirstSide, double SecondSide)
        {
            firstSide = FirstSide;
            secondSide = SecondSide;
        }
        public double AreaCalculator()
        {
            return firstSide * secondSide;
        }
        public double PerimeterCalculator()
        {
            return 2 * (firstSide * secondSide);
        }
    }
}
