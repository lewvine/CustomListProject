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
            CustomList<string> two = new CustomList<string>();
            CustomList<string> result = new CustomList<string>();
            one.Add("one");
            one.Add("two");
            one.Add("three");
            two.Add("one");

            string expected = "[ two ]";
            string actual;
            //Act
            result = one - two;
            actual = result.ToString();

            //Assert
            Console.WriteLine("This is One:" + one);
            Console.WriteLine("This is Two:" + two);
            Console.WriteLine("This is Result:" + result);
            Console.ReadLine();
            
        }
    }
}
