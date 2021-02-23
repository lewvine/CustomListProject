using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class ToStringOverrideUnitTest
    {
        [TestMethod]
        public void To_String_Works_with_Strings()
        {   
            //Arrange
            CustomList<string> collectionOfStrings = new CustomList<string>();
            collectionOfStrings.Add("yes");
            collectionOfStrings.Add("555");
            collectionOfStrings.Add("!@#  ");

            string expected = "[ yes, 555, !@#   ]";
            string actual;

            //Act
            actual = collectionOfStrings.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void To_String_Works_with_Ints()
        {
            //Arrange
            CustomList<int> collectionOfNumbers = new CustomList<int>();
            collectionOfNumbers.Add(1);
            collectionOfNumbers.Add(5);
            collectionOfNumbers.Add(3);

            string expected = "[ 1, 5, 3 ]";
            string actual;

            //Act
            actual = collectionOfNumbers.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void To_String_Has_Predictable_Length()
        {
            //Arrange
            CustomList<int> collectionOfNumbers = new CustomList<int>();
            collectionOfNumbers.Add(1);
            collectionOfNumbers.Add(5);
            collectionOfNumbers.Add(3);

            int expected = 11;
            int actual;

            //Act
            actual = collectionOfNumbers.ToString().Length;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void To_String_Is_a_String()
        {
            //Arrange
            CustomList<int> collectionOfNumbers = new CustomList<int>();
            collectionOfNumbers.Add(1);
            collectionOfNumbers.Add(5);
            collectionOfNumbers.Add(3);

            bool expected = true;
            bool actual;

            //Act
            actual = collectionOfNumbers.ToString() is string;

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
