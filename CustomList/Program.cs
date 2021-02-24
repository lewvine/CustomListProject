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
            CustomList<int> a = new CustomList<int>();
            CustomList<int> b = new CustomList<int>();
            CustomList<int> c = new CustomList<int>();

            a.Add(1);
            a.Add(2);
            a.Add(1);
            a.Add(2);

            b.Add(3);
            b.Add(4);

            b.Add(3);
            b.Add(4);

            b.Add(3);
            b.Add(4);

            c = a + b;
            Console.WriteLine("This is A:" + a);
            Console.WriteLine("This is B:" + b);
            Console.WriteLine("This is C:" + c);
            Console.ReadLine();
            
        }
    }
}
