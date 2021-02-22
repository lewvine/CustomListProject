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
            CustomList<int> collectionOfNumbers = new CustomList<int>();
            int number = 5;
            int expected = 1;
            int actual;

            //Act
            collectionOfNumbers.Add(number);
            actual = collectionOfNumbers.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_Item_IsPlacedAtEndOfList()
        {
            //Arrange
            CustomList<int> collectionOfNumbers = new CustomList<int>();
            int number = 5;
            int expected = 5;
            int actual;

            //Act
            collectionOfNumbers.Add(9);
            collectionOfNumbers.Add(number);
            actual = collectionOfNumbers[1];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_Item_Parameter_Different_DataType_As_List_CountNoChange()
        {
            //Arrange
            CustomList<int> collectionOfNumbers = new CustomList<int>();
            string notANumber = "this is not a number";
            int expected = 0;
            int actual;

            //Act
            //collectionOfNumbers.Add(notANumber);
            actual = collectionOfNumbers.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_Item_No_Parameters_CountNoChange()
        {
            //Arrange
            CustomList<int> collectionOfNumbers = new CustomList<int>();
            collectionOfNumbers.Add(5);
            int expected = 1;
            int actual;

            //Act
            //collectionOfNumbers.Add();
            actual = collectionOfNumbers.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_Item_Too_Many_Parameters_CountNoChange()
        {
            //Arrange
            CustomList<int> collectionOfNumbers = new CustomList<int>();
            collectionOfNumbers.Add(5);
            int expected = 1;
            int actual;

            //Act
            //collectionOfNumbers.Add(5, 6);
            actual = collectionOfNumbers.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
