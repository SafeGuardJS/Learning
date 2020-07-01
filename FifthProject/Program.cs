using System;

namespace FifthProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //var9
            Console.Write("Enter a number of array elements: ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[N];

            enterValuesOfArray(array);
            consoleArrayOutput(ref array);
            Console.WriteLine($"Max element:" + maxElement(array));

            Console.WriteLine(betweenFirstPositiveElemSum(array));
            
            
        }
        static void consoleArrayOutput(ref int[] array)
        {
            foreach (int i in array)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("");
        }
        static int[] enterValuesOfArray(in int[] array)
        {
            Console.WriteLine("Enter values of elements");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"array[{i}] = ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            return array;
        }

        static int maxElement(in int[] array)
        {
            int iMax = 0;
            for(int i = 1; i < array.Length; i++)
            {
                if (array[iMax] < array[i]) { iMax = i; }                
            }

            return array[iMax];
        }

        static int betweenFirstPositiveElemSum(in int[] array)
        {
            int sum = 0;

            for(int i = 0, counter = 0; i < array.Length; i++)
            {
                
                if (array[i] >= 0)
                {
                    counter++;
                    continue;
                }

                if (counter == 1) sum += array[i];
                else if(counter > 1) break;
            }

            return sum;
        }
    }
}
