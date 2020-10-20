using System;

namespace Colors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter sentence: ");
            string sent = Console.ReadLine();

            Console.WriteLine("Available colors: ");
            for(Color i = Color.red; i <= Color.green; i++)
            {
                Console.WriteLine("{0:D} - {0}", i);
            }

            Console.WriteLine("Enter color number: ");
            int colorNum = Convert.ToInt32(Console.ReadLine());

            ColoredOutput.Print(sent, colorNum);
        }
    }

    static class ColoredOutput
    {
        static public void Print(string sentence, int color)
        {
            switch (color)
            {
                case (int)Color.red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case (int)Color.blue:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case (int)Color.green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                default:
                    Console.WriteLine("Please, enter valid value!");
                    break;
            }

            Console.WriteLine(sentence);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    enum Color
    {
        red,
        blue,
        green
    }
}
