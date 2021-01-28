using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList;

namespace CustomList_UnitTest
{
    [TestClass]
    public class ZipMethod
    {
        [TestMethod]
        public void ZipCustomIntLists_CheckCount6()
        {
            //Arrange
            TheCustomList<int> list1 = new TheCustomList<int>();
            TheCustomList<int> list2 = new TheCustomList<int>();

            int a = 1;
            int b = 3;
            int c = 5;
            int d = 2;
            int e = 4;
            int f = 6;
            int expected = 6;
            int actual;

            //Act
            list1.Add(a);
            list1.Add(b);
            list1.Add(c);
            list2.Add(d);
            list2.Add(e);
            list2.Add(f);

            TheCustomList<int> result1 = list1.Zip(list2);
            actual = result1.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ZipCustomIntLists_CheckIndex1()
        {
            //Arrange
            TheCustomList<int> list1 = new TheCustomList<int>();
            TheCustomList<int> list2 = new TheCustomList<int>();

            int a = 1;
            int b = 3;
            int c = 5;
            int d = 2;
            int e = 4;
            int f = 6;
            int expected = 2;
            int actual;

            //Act
            list1.Add(a);
            list1.Add(b);
            list1.Add(c);
            list2.Add(d);
            list2.Add(e);
            list2.Add(f);

            TheCustomList<int> result1 = list1.Zip(list2);
            actual = result1[1];
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ZipCustomCharLists_CheckStringFormed()
        {
            //Arrange
            TheCustomList<char> list1 = new TheCustomList<char>();
            TheCustomList<char> list2 = new TheCustomList<char>();

            char char1 = 'h';
            char char2 = 'e';
            char char3 = 'l';
            char char4 = 'l';
            char char5 = 'o';
            char char6 = '!';
            string expected = "hello!";
            string actual;

            //Act
            list1.Add(char1);
            list1.Add(char3);
            list1.Add(char5);
            list2.Add(char2);
            list2.Add(char4);
            list2.Add(char6);

            TheCustomList<int> result1 = list1.Zip(list2);
            actual = result1.ToString();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ZipCustomUnevenIntLists_CheckIndex5()
        {
            //Arrange
            TheCustomList<int> list1 = new TheCustomList<int>();
            TheCustomList<int> list2 = new TheCustomList<int>();

            int a = 1;
            int b = 3;
            int c = 5;
            int d = 2;
            int e = 4;
            int f = 6;
            int expected = 2;
            int actual;

            //Act
            list1.Add(a);
            list1.Add(b);
            list1.Add(c);
            list1.Add(d);
            list2.Add(e);
            list2.Add(f);

            TheCustomList<int> result1 = list1.Zip(list2);
            actual = result1[5];
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ZipCustomIntListWithEmptyList_CheckCount()
        {
            //Arrange
            TheCustomList<int> list1 = new TheCustomList<int>();
            TheCustomList<int> list2 = new TheCustomList<int>();

            int a = 1;
            int b = 2;
            int c = 3;
            int expected = 3;
            int actual;

            //Act
            list1.Add(a);
            list1.Add(b);
            list1.Add(c);
            

            TheCustomList<int> result1 = list1.Zip(list2);
            actual = result1.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
