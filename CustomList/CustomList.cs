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

        //Member variabls AKA properties
        public int Count
        {
            get { return count; }
        }

        //Member properties


        //Constructor
        public CustomList()
        {
            this.count = 0;
            this.capacity = 0;
        }


        //Member methods
        public void Add(T item)
        {
            count++;
            capacity++;
        }
    }
}
