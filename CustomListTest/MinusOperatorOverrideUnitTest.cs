using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class MinusOperatorOverrideUnitTest
    {
        [TestMethod]
        public void Minus_Operator_New_List_Returns_Original_When_No_Matches()
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

            string expected = "[ 1, 2, 3 ]";
            string actual;
            //Act
            result = one - two;
            actual = result.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Minus_Operator_New_List_Returns_Original_When_ListTwo_Empty()
        {
            //Arrange
            CustomList<int> one = new CustomList<int>();
            CustomList<int> two = new CustomList<int>();
            CustomList<int> result = new CustomList<int>();
            one.Add(1);
            one.Add(2);
            one.Add(3);

            string expected = "[ 1, 2, 3 ]";
            string actual;
            //Act
            result = one - two;
            actual = result.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Minus_Operator_New_List_Deletes_Numbers_Present_In_Both_Lists()
        {
            //Arrange
            CustomList<int> one = new CustomList<int>();
            CustomList<int> two = new CustomList<int>();
            CustomList<int> result = new CustomList<int>();
            one.Add(1);
            one.Add(2);
            one.Add(3);
            two.Add(1);
            two.Add(2);
            two.Add(6);

            string expected = "[ 3 ]";
            string actual;
            //Act
            result = one - two;
            actual = result.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Minus_Operator_New_List_Deletes_Only_One_Instance_Per_Occurence()
        {
            //Arrange
            CustomList<int> one = new CustomList<int>();
            CustomList<int> two = new CustomList<int>();
            CustomList<int> result = new CustomList<int>();
            one.Add(1);
            one.Add(1);
            one.Add(3);
            two.Add(1);

            string expected = "[ 1 ]";
            string actual;
            //Act
            result = one - two;
            actual = result.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Minus_Operator_Works_With_Strings()
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
            Assert.AreEqual(expected, actual);
        }
    }
}
