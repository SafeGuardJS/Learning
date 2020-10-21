using System;

namespace DelagateArray
{
    class Program
    {
        static public int GetRand()
        {
            return new Random().Next(0, 101);
        }

        public delegate int RandomNum();
        public delegate double CalculateAvarage(params RandomNum[] values);
         
        static void Main(string[] args)
        {
            RandomNum num = Program.GetRand;

            CalculateAvarage avarage = values =>
            {
                double sum = 0;
                double key;

                for (int i = 0; i < values.Length; i++)
                {
                    key = values[i]();
                    Console.Write(key + " ");
                    sum += key;
                }

                Console.WriteLine();
                return sum / values.Length;
            };

            Console.WriteLine(avarage(num, num, num, num, num));
        }
    }
}