using System;

namespace GenericFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Program absurd = MyClass<Program>.FactoryMethod();
        }
    }

    class MyClass<T> where T : new()
    {
        public static T FactoryMethod()
        {
            return new T();
        }
    }
}
