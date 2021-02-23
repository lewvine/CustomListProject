using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> list = new CustomList<int>();
            list.Add(3);
            list.Add(5);
            list.Add(9);
            list.Add(5);
            list.Remove(5);

            string listTo = list.ToString();
            Console.WriteLine(listTo);
            Console.ReadLine();
            
        }
    }
}
