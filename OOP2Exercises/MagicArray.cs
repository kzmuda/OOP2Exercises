using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2Exercises
{
    class MagicArray<T>
    {
        private T[] data;
        private int index;

        public MagicArray(int elementCount)
        {
            data = new T[elementCount];
            index = 0;
        }

        public void Add(T element)
        {
            data[index % data.Length] = element;
            index++;
        }

        public T GetFirst()
        {
            return data[0];
        }

        public void Print()
        {
            foreach (var i in data)
            {
                Console.Out.WriteLine(i);
            }
        }
    }
}
