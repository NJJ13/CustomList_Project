using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList;


namespace CustomList_UnitTest
{
    [TestClass]
    public class RemoveMethod
    {
        [TestMethod]
        public void RemoveItemFromCustomList_CheckCountAt2()
        {
            //Arrange
            TheCustomList<string> list = new TheCustomList<string>();
            string fruit1 = "Banana";
            string fruit2 = "Apple";
            string fruit3 = "Orange";
            int actual;
            int expected = 2;

            //Act
            list.Add(fruit1);
            list.Add(fruit2);
            list.Add(fruit3);
            list.Remove(fruit2);
            actual = list.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveItemFromCustomList_Checkindex0ForNull()
        {
            //Arrange
            TheCustomList<string> list = new TheCustomList<string>();
            string fruit1 = "Banana";
            string expected = null;
            string actual;


            //Act
            list.Add(fruit1);
            list.Remove(fruit1);
            actual = list[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveItemFromCustomList_CheckindexAt1()
        {
            //Arrange
            TheCustomList<string> list = new TheCustomList<string>();
            string fruit1 = "Banana";
            string fruit2 = "Apple";
            string expected = "Orange";
            string actual;
            

            //Act
            list.Add(fruit1);
            list.Add(fruit2);
            list.Add(expected);
            list.Remove(fruit2);
            actual = list[1];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveItemFromCustomList_RemoveIntCheckCount()
        {
            //Arrange
            TheCustomList<int> list = new TheCustomList<int>();
            int number1 = 3;
            int number2 = 6;
            int number3 = 9;
            int expected = 2;
            int actual;


            //Act
            list.Add(number1);
            list.Add(number2);
            list.Add(number3);
            list.Remove(number2);
            actual = list.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        
    }
}
