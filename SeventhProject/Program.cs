using System;

namespace SeventhProject
{
    class Rectengular
    {
        double Side1 { get; set; }
        double Side2 { get; set; }
        public double Perimert 
        {
            get
            {
                return this.Perimeter();
            }
        }
        public double Area
        {
            get
            {
                return this.AreaCalculator();
            }
        }
        public Rectengular() : this(5)
        {
        }
        public Rectengular( double side1) : this( side1, 5)
        {
        }
        public Rectengular( double side1, double side2)
        {
            this.Side1 = side1;
            this.Side2 = side2;
        }

        double AreaCalculator()
        {
            return this.Side1 * this.Side2;
        }

        double Perimeter()
        {
            return 2.0 * (this.Side1 + this.Side2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double side1, side2;

            Console.Write("Enter rectangular sides: \n Firset side: ");
            side1 = Convert.ToDouble(Console.ReadLine());

            Console.Write(" \n Second side: ");
            side2 = Convert.ToDouble(Console.ReadLine());

            Rectengular newRec = new Rectengular( side1,  side2);

            Console.WriteLine($"\n Periment: {newRec.Perimert} \n Area: {newRec.Area}");
        }
    }
}
