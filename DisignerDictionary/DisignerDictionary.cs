using System;
using System.Collections.Generic;
using System.Text;

namespace DisignerDictionary
{
    class DisignerDictionary<TKey, TValue> //validator 
    {
        (TKey key, TValue value)[] dictionary;

        public int DictionaryLength
        {
            get { return this.dictionary.Length; }
        }

        public DisignerDictionary() : this(null)
        {
        }
        public DisignerDictionary(params (TKey key, TValue value)[] arg)
        {
            this.dictionary = arg;
        }

        public string this[TValue index]
        {
            get
            {
                for (int i = 0; i < this.DictionaryLength; i++)
                {
                    if ((string)(object)this.dictionary[i].value == (string)(object)index)
                    {
                        return this.dictionary[i].key + " - " + this.dictionary[i].value + "Index: " + i;
                    }
                }

                return "There are no elements by" + "\'" + index + "\'" + " value.";
            }
        }

        public string this[TKey index]
        {
            get
            {
                for (int i = 0; i < this.DictionaryLength; i++)
                {
                    if ((string)(object)this.dictionary[i].key == (string)(object)index)
                    {
                        return this.dictionary[i].key + " - " + this.dictionary[i].value + "Index: " + i;
                    }
                }

                return "There are no elements by" + "\'" + index + "\'" + " key.";
            }
        }

        public void Add((TKey, TValue) arg)
        {
            (TKey key, TValue value)[] keyDictionary = new (TKey key, TValue value)[this.DictionaryLength + 1];

            for (int i = 0; i < this.DictionaryLength; i++)
            {
                keyDictionary[i] = this.dictionary[i];
            }
            keyDictionary[this.DictionaryLength] = arg;

            this.dictionary = keyDictionary;
        }
    }
}
