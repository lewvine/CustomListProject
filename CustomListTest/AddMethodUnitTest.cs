using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class AddMethodUnitTest
    {
        [TestMethod]
        public void Add_Item_CountIncreasesByOne()
        {
            //Arrange
            CustomListTest<int> collectionOfNumbers = new CustomList<int>();
            int number = 5;
            int expected = 1;
            int actual;

            //Act
            collectionOfNumbers.Add(number);
            actual = collectionOfNumbers.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        public void Add_Item_CountIncreasesByOneIfNull()
        {
            //Arrange
            CustomListTest<int> collectionOfNumbers = new CustomList<int>();
            int number = 5;
            int expected = 1;
            int actual;

            //Act
            collectionOfNumbers.Add(number);
            actual = collectionOfNumbers.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        public void Add_Item_IfInputIsDifferentDataTypeAsList_CountNoChange()
        {
            //Arrange
            CustomListTest<int> collectionOfNumbers = new CustomList<int>();
            string nullString = "";
            int expected = 0;
            int actual;

            //Act
            collectionOfNumbers.Add(nullString);
            actual = collectionOfNumbers.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
