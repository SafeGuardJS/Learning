using System;

namespace Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle plane = new Plane(31, 54, 5000, 800, 2005, 8000, 190);

            plane.GetInfo();
        }
    }
}
