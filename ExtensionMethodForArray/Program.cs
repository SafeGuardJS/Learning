using System;

namespace ExtensionMethodForArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 10, 2, 1, 50, -100 };

            arr = arr.ExtensinSortArray();

            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }

    static class ExtArrMathod
    {
         public static int[] ExtensinSortArray(this int[] arr)
         {            
            int Min;
            int key;

            for(int i = 0; i < arr.Length; i++)
            {
                Min = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if(arr[Min] > arr[j])
                    {
                        Min = j;
                    }
                }

                key = arr[i];
                arr[i] = arr[Min];
                arr[Min] = key;
            }

            return arr;
         }
    }
}
