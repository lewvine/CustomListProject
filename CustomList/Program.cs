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
            //Arrange
            CustomList<string> one = new CustomList<string>();
            one.Add("one");
            one.Add("two");
            one.Add("three");
            one.Add("two");
            one.Add("three");
            one.Add("two");
            one.Add("two");

            one.Sort();


            
        }
    }
}
