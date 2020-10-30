using System;
using System.Collections.Generic;
using System.Text;

namespace DisignerList
{
    static class ListExctension
    {
        public static T[] GetArray<T>(this DisignerList<T> arg)
        {
            T[] res = new T[arg.ListLength];
            
            for(int i = 0; i < arg.ListLength; i++)
            {
                res[i] = arg[i];
            }

            return res;
        }
    }
}
