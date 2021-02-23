using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CustomListTest
{
    [TestClass]
    public class RemoveMethodUnitTest
    {
        [TestMethod]
        public void Remove_Item_Method_Returns_Item()
        {
            //Arrange
            CustomList<int> collectionOfNumbers = new CustomList<int>();
            collectionOfNumbers.Add(5);
            collectionOfNumbers.Add(9);
            int expected = 9;
            int actual;

            //Act
            actual = collectionOfNumbers.Remove(9);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_Item_Method_Decrements_Count_By_One()
        {
            //Arrange
            CustomList<int> collectionOfNumbers = new CustomList<int>();
            collectionOfNumbers.Add(5);
            collectionOfNumbers.Add(9);
            collectionOfNumbers.Remove(9);
            int expected = 1;
            int actual;

            //Act
            actual = collectionOfNumbers.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_Item_Method_Does_Not_Change_Capacity()
        {
            //Arrange
            CustomList<int> collectionOfNumbers = new CustomList<int>();
            collectionOfNumbers.Add(4);
            collectionOfNumbers.Add(5);
            collectionOfNumbers.Add(6);
            collectionOfNumbers.Add(7);
            collectionOfNumbers.Add(9);

            collectionOfNumbers.Remove(9);
            int expected = 8;
            int actual;

            //Act
            actual = collectionOfNumbers.Capacity;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_Item_Method_Does_Not_Change_Count_If_Parameter_Not_In_List()
        {
            //Arrange
            CustomList<int> collectionOfNumbers = new CustomList<int>();
            collectionOfNumbers.Add(4);
            collectionOfNumbers.Add(5);
            collectionOfNumbers.Add(6);

            collectionOfNumbers.Remove(9);
            int expected = 3;
            int actual;

            //Act
            actual = collectionOfNumbers.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
