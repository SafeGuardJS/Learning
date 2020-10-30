using System;
using System.Collections.Generic;
using System.Text;

namespace DisignerList
{
    class DisignerList<T>
    {
        T[] list;

        public int ListLength
        {
            get { return this.list.Length; }
        }

        public DisignerList() : this(null)
        {
        }
        public DisignerList(params T[] arg)
        {
            this.list = arg;
        }

        public T this[int index]
        {
            get { return this.list[index]; }
        }

        public void Add(T arg)
        {
            T[] keyList = new T[this.ListLength + 1];

            for (int i = 0; i < this.ListLength; i++)
            {
                keyList[i] = this.list[i];
            }
            keyList[this.ListLength] = arg;

            this.list = keyList;
        }
    }
}
