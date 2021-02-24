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
            get { return capacity; }
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
                int j = 0;
                for (int i = 0; i <= _items.Length - 1; i++)
                {
                    newArray[i] = _items[i];
                    j = i;
                }
                newArray[capacity] = item;
                _items = newArray;
                j += 2;
                capacity *= 2;
                count = j;
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
            if (containsItem == true)
            {
                Count--;
            }
            return containsItem;
        }
    

        public override string ToString()
        {
            string listToString = "[";
            for(int i = 0; i <= Count - 1; i++) 
            {
                if (i < Count -1)
                {
                    listToString += $" {_items[i]},";
                }
                else
                {
                    listToString += $" {_items[i]} ";

                }
            }
            listToString += "]";

            return listToString;
        }

        public static CustomList<T> operator+ (CustomList<T> a, CustomList<T> b)
        {
            CustomList<T> c = new CustomList<T>();
            int counter = a.Count + b.Count - 1;
            int j = 0;
            for(int i = 0; i <= counter; i++)
            {
                if(i < a.Count)
                {
                    c.Add(a[i]);
                }
                else
                {
                    c.Add(b[j]);
                    j++;
                }
            }
            return c;
        }

        public static CustomList<T> operator-(CustomList<T> a, CustomList<T> b)
        {
            for(int i = 0; i < a.count; i++)
            {
                foreach(T item in b._items)
                {
                    if(a._items[i].Equals(item))
                    {
                        a.Remove(item);
                    }
                }
            }
            return a;
        }
    }
}
