using System;

namespace ThirdProject
{
    class Program
    {
        static void Main(string[] args)
        {
            (double x, double y) point;
            Console.Write("Enter coords of point  for var №9\n x: ");
            point.x = Convert.ToDouble(Console.ReadLine());
            Console.Write(" y: ");
            point.y = Convert.ToDouble(Console.ReadLine());

            if (point.x <= 0 && point.y <= 0 && (Math.Pow(point.x, 2) + Math.Pow(point.y, 2)) <= 4
               || point.x >= 1 && Math.Pow(point.x, 2) >= point.y && (Math.Pow(point.x, 2) + Math.Pow(point.y, 2)) <= 4)
            {
                Console.WriteLine("Point belongs to the area");
            }
            else
            {
                Console.WriteLine("Point doesn't belong to the area");
            }
            Console.Write("Enter coords of point  for var №10\n x: ");
            point.x = Convert.ToDouble(Console.ReadLine());
            Console.Write(" y: ");
            point.y = Convert.ToDouble(Console.ReadLine());

            if (point.y >= 2.5F && point.y <= 0 && Math.Pow(point.x, 2) + Math.Pow(point.y, 2) <= 4
                || point.x <= 3 && point.y >= 0 && point.y <= 2.5F && Math.Pow(point.x, 2) + Math.Pow(point.y, 2) >= 4)
            {
                Console.WriteLine("Point belongs to the area");
            }
            else
            {
                Console.WriteLine("Point doesn't belong to the area");
            }
        }
    }
}