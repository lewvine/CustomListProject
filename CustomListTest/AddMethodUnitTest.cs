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
            actual = collectionOfNumbers.GetIndex(1);

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

        [TestMethod]
        public void Add_Item_Capacity4_Count4_Increases_Capacity()
        {
            //Arrange
            CustomList<int> collectionOfNumbers = new CustomList<int>();
            collectionOfNumbers.Add(0);
            collectionOfNumbers.Add(1);
            collectionOfNumbers.Add(2);
            collectionOfNumbers.Add(3);
            collectionOfNumbers.Add(4);

            int expected = 8;
            int actual;

            //Act
            //collectionOfNumbers.Add(5, 6);
            actual = collectionOfNumbers.Capacity;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        //New array should have 0s in indices after 5.
        public void Add_Item_Capacity4_Count4_Increases_Capacity_Item6is0()
        {
            //Arrange
            CustomList<int> collectionOfNumbers = new CustomList<int>();
            collectionOfNumbers.Add(0);
            collectionOfNumbers.Add(1);
            collectionOfNumbers.Add(2);
            collectionOfNumbers.Add(3);
            collectionOfNumbers.Add(4);

            int expected = 0;
            int actual;

            //Act
            //collectionOfNumbers.Add(5, 6);
            actual = collectionOfNumbers.GetIndex(6);

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
