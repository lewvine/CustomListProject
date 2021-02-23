using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {

        //Member variables AKA fields
        private int count;
        private int capacity;
        private T[] _items;

        //Member variables AKA properties
        public int Count
        {
            get { return count; }
        }

        public int Capacity
        {
            get { return capacity;  }
        }

        public T GetIndex(int x)
        {
            return _items[x];
        }



        //Constructor
        public CustomList()
        {
            count = 0;
            capacity = 4;
            _items = new T[capacity];
        }


        //Member methods
        public void Add(T item)
        {
            if (count < capacity)
            {
                _items[count] = item;
                count++;
            }
            else
            {
                T[] newArray = new T[capacity * 2];
                for (int i = 0; _items.Length <= i; i++)
                {
                    newArray[i] = _items[i];
                }
                newArray[capacity + 1] = item;
                _items = newArray;
                capacity *= 2;
            }
        }
                
    }
}
