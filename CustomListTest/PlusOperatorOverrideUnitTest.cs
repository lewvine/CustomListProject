using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class PlusOperatorOverloadUnitTest
    {
        [TestMethod]
        public void Plus_Operator_New_List_ToString_LooksRight()
        {
            //Arrange
            CustomList<int> one = new CustomList<int>();
            CustomList<int> two = new CustomList<int>();
            CustomList<int> result = new CustomList<int>();
            one.Add(1);
            one.Add(2);
            one.Add(3);
            two.Add(4);
            two.Add(5);
            two.Add(6);

            string expected = "[ 1, 2, 3, 4, 5, 6 ]";
            string actual;
            //Act
            result = one + two;
            actual = result.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Plus_Operator_New_List_Right_Length()
        {
            //Arrange
            CustomList<int> one = new CustomList<int>();
            CustomList<int> two = new CustomList<int>();
            CustomList<int> result = new CustomList<int>();
            one.Add(1);
            one.Add(2);
            one.Add(3);
            two.Add(4);
            two.Add(5);
            two.Add(6);

            int expected = 20;
            int actual;
            //Act
            result = one + two;
            string resultString = result.ToString();
            actual = resultString.Length;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Plus_Operator_Returns_Right_Length_If_Null_Values()
        {
            //Arrange
            CustomList<int> one = new CustomList<int>();
            CustomList<int> two = new CustomList<int>();
            CustomList<int> result = new CustomList<int>();

            string expected = "[]";
            string actual;
            //Act
            result = one + two;
            actual = result.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Plus_Operator_Returns_Same_String_As_ToString_Each_Separate_List()
        {
            //Arrange
            CustomList<int> one = new CustomList<int>();
            CustomList<int> two = new CustomList<int>();
            one.Add(1);
            one.Add(2);
            one.Add(3);
            two.Add(4);
            two.Add(5);
            two.Add(6);
            string oneStr = one.ToString();
            string twoStr = two.ToString();
            string expected = "[ 1, 2, 3 ][ 4, 5, 6 ]";
            string actual;
            //Act
            actual = oneStr + twoStr;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Plus_Operator_New_List_ToString_Works_With_Strings()
        {
            //Arrange
            CustomList<string> one = new CustomList<string>();
            CustomList<string> two = new CustomList<string>();
            CustomList<string> result = new CustomList<string>();
            one.Add("one");
            one.Add("two");
            one.Add("three");
            two.Add("four");
            two.Add("five");
            two.Add("six");

            string expected = "[ one, two, three, four, five, six ]";
            string actual;
            //Act
            result = one + two;
            actual = result.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
