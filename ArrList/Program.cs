using System;
using System.Collections;
using System.Collections.Generic;

namespace ArrList
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass testClass = new TestClass();

            ArrayList testList = new ArrayList();

            testList.Add(1);
            testList.Add(testClass);

            Console.WriteLine(testList.Count);
        }
    }

    class TestClass
    {

    }
}
