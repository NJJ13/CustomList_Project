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
            TheCustomList<string> list = new TheCustomList<string>();
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
            TheCustomList<string> list = new TheCustomList<string>();
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
            TheCustomList<string> list = new TheCustomList<string>();
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
            TheCustomList<string> list = new TheCustomList<string>();
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
            TheCustomList<int> list = new TheCustomList<int>();
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

        [TestMethod]
        public void AddItemToCustomList_CheckCapacityAt1()
        {
            //Arrange
            TheCustomList<string> list = new TheCustomList<string>();
            string fruit = "Apple";
            int expected = 4;
            int actual;

            //Act
            list.Add(fruit);
            actual = list.Capacity;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddItemToCustomList_CheckCapacityAt5()
        {
            //Arrange
            TheCustomList<string> list = new TheCustomList<string>();
            int number1 = 2;
            int number2 = 6;
            int number3 = 8;
            int number4 = 10;
            int number5 = 12;
            int expected = 8;
            int actual;

            //Act
            list.Add(number1);
            list.Add(number2);
            list.Add(number3);
            list.Add(number4);
            list.Add(number5);
            actual = list.Capacity;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddItemToCustomList_CheckIndexAt1AfterArrayReplaced()
        {
            //Arrange
            TheCustomList<string> list = new TheCustomList<string>();
            int number1 = 2;
            int number2 = 6;
            int number3 = 8;
            int number4 = 10;
            int number5 = 12;
            int expected = 6;
            int actual;

            //Act
            list.Add(number1);
            list.Add(number2);
            list.Add(number3);
            list.Add(number4);
            list.Add(number5);
            actual = list[1];

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
}
