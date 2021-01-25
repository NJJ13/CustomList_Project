using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList;

namespace CustomList_UnitTest
{
    [TestClass]
    public class AddMethod
    {
        [TestMethod]
        public void AddItemToCustomList_CheckCount1()
        {
            //Arrange
            TheCustomList list = new TheCustomList();
            string fruit = "Banana";
            int actual;
            int expected = 1;


            //Act
            list.Add(fruit);
            actual = list.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddItemToCustomList_CheckForItemAtIndex0()
        {
            //Arrange
            TheCustomList list = new TheCustomList();
            string expected = "Banana";
            string actual;

            //Act
            list.Add(expected);
            actual = list[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddItemToCustomList_CheckCount3()
        {
            //Arrange
            TheCustomList list = new TheCustomList();
            string fruit = "Banana";
            int expected = 3;
            int actual;

            //Act
            list.Add(fruit);
            list.Add(fruit);
            list.Add(fruit);
            actual = list.Count;

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void AddItemToCustomList_CheckForItemAtIndex2()
        {
            //Arrange
            TheCustomList list = new TheCustomList();
            string fruit1 = "Apple";
            string fruit2 = "Orange";
            string expected = "Banana";
            string actual;

            //Act
            list.Add(fruit1);
            list.Add(fruit2);
            list.Add(expected);
            actual = list[2];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddItemToCustomList_AddInt()
        {
            //Arrange
            TheCustomList list = new TheCustomList();
            int number = 4;
            int expected1 = 1;
            int actual1;
            int expected2 = 4;
            int actual2;


            //Act
            list.Add(number);
            actual1 = list.Count;
            actual2 = list[0];

            //Assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }
    }
}
