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
            set { count = value; }
        }

        public int Capacity
        {
            get { return capacity;  }
        }

        public T[] Items
        {
            get { return _items; }
        }


        public T this[int index]
        {
            get
            {
                return _items[index];
            }
            set
            {
                _items[index] = value;
            }
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
                Count++;
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

        //Member methods
        public bool Remove(T item)
        {
            bool containsItem = false;
            T[] newArray = new T[capacity];
            int j = 0;
            int counter = 0;
            for (int i = 0; i <= Count - 1; i++)
            {
                if (_items[i].Equals(item) && counter == 0)
                {
                    containsItem = true;
                    counter = 1;
                    continue;
                }
                else
                {
                    newArray[j] = _items[i];
                    j++;
                }
            }
            _items = newArray;
            if(containsItem == true)
            {
                Count--;
            }
            return containsItem;
            }
        }
    }
