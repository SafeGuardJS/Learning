using System;

namespace DocumentWorker
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentWorker doc = null;

            switch (Console.ReadLine())
            {
                case "exp":
                    doc = new ExpertDocumentWorker();
                    break;
                case "pro":
                    doc = new ProDocumentWorker();
                    break;
                default:
                    doc = new DocumentWorker();
                    break;
            }
        }
    }
}
