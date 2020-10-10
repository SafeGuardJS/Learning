using System;
using System.Collections.Generic;
using System.Text;

namespace Indexers
{
    class Store
    {
        Article[] internetStore = new Article[5];
        
        public Store()
        {
            for(int i = 0; i < internetStore.Length; i++)
            {
                internetStore[i] = new Article();
            }

            internetStore[0].ProductName = "apple";
            internetStore[0].ProductPrice = 12;
            internetStore[0].StoreName = "Fruit shop";

            internetStore[1].ProductName = "Pear";
            internetStore[1].ProductPrice = 44;
            internetStore[1].StoreName = "Fruit shop";

            internetStore[2].ProductName = "Lemon";
            internetStore[2].ProductPrice = 33;
            internetStore[2].StoreName = "Fruit shop";

            internetStore[3].ProductName = "Newspaper";
            internetStore[3].ProductPrice = 2;
            internetStore[3].StoreName = "Newspaper's";

            internetStore[4].ProductName = "Bread";
            internetStore[4].ProductPrice = 8;
            internetStore[4].StoreName = "Baker's";
        }

        public string this[int index]
        {
            get
            {
                return "Product: " + internetStore[index].ProductName + "\nPrice: " + internetStore[index].ProductPrice + "\nStore: " + internetStore[index].StoreName;
            }
        }        

        public string this[string index]
        {
            get
            {
                for(int i = 0; i < this.internetStore.Length; i++)
                {
                    if (internetStore[i].ProductName.ToLower() == index.ToLower())
                        return "Price: " + this.internetStore[i].ProductPrice + "\nStore: " + internetStore[i].StoreName;
                }
                return $"The is no \'{index}\' product!";
            }
        }

        //void ChangeWholeElementsOfArray(ref int[] array)
        //{
        //    for(int i = 0; i < array.Length; i++)
        //    {
        //        Console.Write($"\nEnter {i + 1} element: ");
        //        array[i] = Convert.ToInt32(Console.ReadLine());
        //    }
        //}
        //void ChangeExactElementsOfArray(ref int[] array, params int[] indexes)
        //{
        //    for (int i = 0; i < indexes.Length; i++)
        //    {
        //        Console.Write($"\nEnter {indexes[i + 1]} element: ");
        //        array[indexes[i]] = Convert.ToInt32(Console.ReadLine());
        //    }
        //}

        //int[] CreateNewArray()
        //{
        //    Console.WriteLine("Enter number of elemtns: ");
        //    int N = Convert.ToInt32(Console.ReadLine());

        //    int[] newArray = new int[N];

        //    for (int i = 0; i < N; i++)
        //    {
        //        Console.Write($"\nEnter {i + 1} element: ");
        //        newArray[i] = Convert.ToInt32(Console.ReadLine());
        //    }

        //    return newArray;
        //}

        //int MaxElement(ref int[] arr)
        //{
        //    int Max = arr[0];

        //    for(int i = 1; i < arr.Length; i++)
        //    {
        //        if (Max < arr[i]) Max = arr[i];
        //    }

        //    return Max;
        //}
    }
}
