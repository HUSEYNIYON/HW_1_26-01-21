using System;

namespace HW_1_26_01_21
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task-1 DZ-1
            Console.Write("Enter First side = ");
            double firstSide = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Second side = ");
            double secondSide = Convert.ToDouble(Console.ReadLine());
            var rect = new Rectangle(firstSide, secondSide);
            Console.WriteLine($"Area = {rect.AreaCalculator()}");
            Console.WriteLine($"Perimeter = {rect.PerimeterCalculator()}");
            
        }
    }
    class Rectangle
    {
        public double firstSide { get; private set; }
        public double secondSide { get; private set; }
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
            return 2 * (firstSide + secondSide);
        }
    }
}
