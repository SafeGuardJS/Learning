using System;

namespace FifthProject
{
    class Program
    {
        static void Main(string[] args)
        {      
            Console.Write("Enter a number of array elements: ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[N];
            enterValuesOfArray(array);

            consoleArrayOutput(ref array);
            Console.WriteLine("max: " + maxModuleArrayElement(array) + "\t min: " + minModuleArrayElemtn(array));
        }
        //var9
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

        static int maxModuleArrayElement(in int[] array)
        {
            int iModuleMax = 0;
            for(int i = 1; i < array.Length; i++)
            {
                if (Math.Abs(array[iModuleMax]) < Math.Abs(array[i])) { iModuleMax = i; }                
            }

            return array[iModuleMax];
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

        static void zerosToEnd(ref int[] arr)
        {
            for(int i = 0, counter = 0; i < arr.Length; i++)
            {
                if(arr[i] == 0)
                {
                    while(arr.Length - counter - 1 == 0) { counter++; }
                    arr[i] = arr[arr.Length - counter - 1];
                    arr[arr.Length - counter - 1] = 0;
                }
            }
        }

        //var10
        static int minModuleArrayElemtn(in int[] array)
        {
            int iMinModElement = 0;

            for(int i = 1; i < array.Length; i++)
            {
                if(Math.Abs(array[iMinModElement]) > Math.Abs(array[i])) iMinModElement = i; 
            }

            return array[iMinModElement];
        }

        static int sumAfterFirstZero(in int[] arr)
        {
            int sum = 0;

            for(int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == 0)
                {
                    while(i < arr.Length - 1)
                    {
                        sum += arr[i + 1];
                        i++;
                    }
                    break;
                }
            }

            return sum;
        }

        static void evenOddIndexSeparation(ref int[] arr)
        {
            int key;
            
            for(int i = 1; i < arr.Length / 2; i += 2)
            {
                key = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = key;
            }
        }
    }
}
