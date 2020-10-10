using System;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            Store myStore = new Store();

           
            Console.WriteLine(myStore["Apple"]);

            string rando = "AbCD";

            //Console.WriteLine(rando.ToLower());
        }
    }
}
