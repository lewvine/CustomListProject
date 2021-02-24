using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class ZipMethodUnitTest
    {
        [TestMethod]
        public void Zip_List_Works_With_Integers()
        {
            //Arrange
            CustomList<int> a = new CustomList<int>();
            CustomList<int> b = new CustomList<int>();

            a.Add(1);
            a.Add(2);
            b.Add(3);
            b.Add(4);

            string expected = "[ 1, 3, 2, 4 ]";
            string actual;
           
            //Act
            actual = a.Zip(b).ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Zip_List_Works_With_Strings()
        {
            //Arrange
            CustomList<string> a = new CustomList<string>();
            CustomList<string> b = new CustomList<string>();

            a.Add("one");
            a.Add("two");
            b.Add("three");
            b.Add("four");

            string expected = "[ one, three, two, four ]";
            string actual;

            //Act
            actual = a.Zip(b).ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Zip_List_Count_Is_Sum_of_Each_Parameter_Lists_Count()
        {
            //Arrange
            CustomList<string> a = new CustomList<string>();
            CustomList<string> b = new CustomList<string>();

            a.Add("one");
            a.Add("two");
            b.Add("three");
            b.Add("four");

            int aCount = a.Count;

            int expected = 4;
            int actual;
            //Act
            a.Zip(b);
            actual = aCount + b.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Zip_List_Works_With_Different_Sized_Lists()
        {
            //Arrange
            CustomList<string> a = new CustomList<string>();
            CustomList<string> b = new CustomList<string>();

            a.Add("one");
            b.Add("three");
            b.Add("four");

            string expected = "[ one, three, four ]";
            string actual;

            //Act
            actual = a.Zip(b).ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Zip_List_Works_With_Empty_Lists()
        {
            //Arrange
            CustomList<string> a = new CustomList<string>();
            CustomList<string> b = new CustomList<string>();

            a.Add("one");


            string expected = "[ one ]";
            string actual;

            //Act
            actual = a.Zip(b).ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
