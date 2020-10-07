using System;

namespace AbstractHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            Redactor newFile = new Redactor("Lab1 .doc");

            newFile.Chenge();
        }
    }
}
