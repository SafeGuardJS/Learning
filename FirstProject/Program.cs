using System;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            StaticFirst.Message();
        }

        static class StaticFirst
        {
            static int number = 4;

            static StaticFirst()
            {
                Console.WriteLine("Static constructor!");
                number = 5;
            }

            public static void Message()
            {
                Console.WriteLine("First message!");
            }
        }
    }
}
