using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    class Vehicle
    {
        double x;
        public double X
        {
            get { return x; }
        }

        double y;
        public double Y
        {
            get { return y; }
        }

        double price;
        public double Price
        {
           get { return price; }
        }

        double speed;
        public double Speed
        {
            get { return speed; }
        }

        readonly int yearOfIssue;
        public int YearOfIssue
        {
            get { return yearOfIssue; }
        }

        public Vehicle(double x, double y, double price, double speed, int yearOfIssue)
        {
            this.x = x;
            this.y = y;
            this.price = price;
            this.speed = speed;
            this.yearOfIssue = yearOfIssue;
        }

        public virtual void GetInfo()
        {
            Console.WriteLine("X: {0} Y: {1} \nPrice: {2} \nSpeed: {3} \nYear of issue: {4}", X, Y, Price, Speed, YearOfIssue);
        }
    }

    class Plane : Vehicle
    {
        double height;
        public double Height
        {
            get { return height; }
        }

        int numberOfPassengers;
        public int NumberOfPassengers
        {
            get { return numberOfPassengers; }
        }

        public Plane(double x, double y, double price, double speed, int yearOfIssue, double height, int numberOfPassengers)
               :base( x, y, price, speed, yearOfIssue)
        {
            this.height = height;
            this.numberOfPassengers = numberOfPassengers;
        }

        public override void GetInfo()
        {
            Console.WriteLine("\tPlane");
            base.GetInfo();
            Console.WriteLine("Height: {0} \nNumber of passengers: {1}", Height, NumberOfPassengers);
        }
    }

    class Car : Vehicle
    {
        public Car(double x, double y, double price, double speed, int yearOfIssue)
               : base(x, y, price, speed, yearOfIssue)
        {
        }
    }

    class Ship : Vehicle
    {
        int numberOfPassengers;
        public int NumberOfPassengers
        {
            get { return numberOfPassengers; }
        }

        string portName;
        public string PortName
        {
            get { return portName; }
        }

        public Ship(double x, double y, double price, double speed, int yearOfIssue, int numberOfPassengers, string portName)
               : base(x, y, price, speed, yearOfIssue)
        {
            this.numberOfPassengers = numberOfPassengers;
            this.portName = portName;
        }

        public override void GetInfo()
        {
            Console.WriteLine("\tPlane");
            base.GetInfo();
            Console.WriteLine("Port name: {0}\n Number of passengers: {1}", PortName, NumberOfPassengers);
        }
    }
}
