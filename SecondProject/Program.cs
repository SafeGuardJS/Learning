using System;

namespace SecondProject
{
    class Program
    {
     
        static void Main(string[] args)
        {
            const double PositiveInfinity = Double.PositiveInfinity;
            double x, y = PositiveInfinity;

            Console.Write("Enter x for var №9: ");
            x = Convert.ToSingle(Console.ReadLine());

           //////////var №9///////////
           if(x >= -7.0F && x < -3.0F)
            {
                y = x + 7;               
            }
            else if (x >= -3.0F && x < -2.0F)
            {
                y = 4;               
            }
            else if (x >= -2.0F && x < 2.0F)
            {
                y = Math.Pow(x, 2);         
            }
            else if (x >= 2.0F && x <= 4.0F)
            {
                y = -2 * x  + 8;               
            }
            else
            {
                Console.WriteLine("Out of range"); 
            }

            Console.WriteLine($"y: {y}");

            //////////var №10///////////
            Console.WriteLine("Enter x for var №10: ");
            x = Convert.ToSingle(Console.ReadLine());
            if (x >= -10.0F && x < -6.0F)
            {
                (double x1, double x2) roots = getSquareEquationRoots((1.0F, -4.0F, Math.Pow((x + 8.0F), 2)));

                if(roots.x1 > 2)
                {
                    y = roots.x2;
                }
                else
                {
                    y = roots.x1;
                }
            }
            else if (x >= -6.0F && x < -4.0F)
            {
                y = 2;
            }
            else if (x >= -4.0F && x < 2.0F)
            {
                y = -x / 2;
            }
            else if (x >= 2.0F && x <= 4.0F)
            {
                y = x - 3;
            }
            else
            {
                Console.WriteLine("Out of range");
            }

            Console.WriteLine($"y: {y}");

            Console.WriteLine(-0 == 0);
        }

        static (double x1, double x2) getSquareEquationRoots((double a, double b, double c) coefficients)
        {
            (double x1, double x2) roots;

            double discriminant = Math.Pow(coefficients.b, 2) - 4 * coefficients.a * coefficients.c;
            roots.x1 = (-coefficients.b + Math.Sqrt(discriminant)) / 2 * coefficients.a;
            roots.x2 = (-coefficients.b - Math.Sqrt(discriminant)) / 2 * coefficients.a;

            return roots;
        }
    }
}
