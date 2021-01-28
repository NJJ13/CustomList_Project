using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList;

namespace CustomList_UnitTest
{
    [TestClass]
    public class OverloadSubtractionOperatorMethod
    {
        [TestMethod]
        public void OverloadOperatorSubtractIntLists()
        {
            //Arrange
            TheCustomList<int> list1 = new TheCustomList<int>();
            TheCustomList<int> list2 = new TheCustomList<int>();
            int a = 1;
            int b = 2;
            int c = 3;
            int d = 4;
            string expected = "13";
            string actual;

            //Act
            list1.Add(a);
            list1.Add(b);
            list1.Add(c);
            list1.Add(d);
            list2.Add(b);
            list2.Add(d);

            TheCustomList<int> result1 = list1 - list2;
            actual = result1.ToString();
            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void OverloadOperatorSubtractStringLists()
        {
            //Arrange
            TheCustomList<string> list1 = new TheCustomList<string>();
            TheCustomList<string> list2 = new TheCustomList<string>();
            string a = "Hello";
            string b = "I";
            string c = "Am";
            string d = "A";
            string e = "New";
            string f = "String";
            string expected = "IAmNew";
            string actual;

            //Act
            list1.Add(a);
            list1.Add(b);
            list1.Add(c);
            list1.Add(d);
            list1.Add(e);
            list1.Add(f);
            list2.Add(a);
            list2.Add(d);
            list2.Add(f);

            TheCustomList<string> result1 = list1 - list2;
            actual = result1.ToString();
            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void OverloadOperatorSubtractStringListWithNoCommonItems()
        {
            //Arrange
            TheCustomList<string> list1 = new TheCustomList<string>();
            TheCustomList<string> list2 = new TheCustomList<string>();
            string a = "Hello";
            string b = "I";
            string c = "Am";
            string d = "A";
            string e = "New";
            string f = "String";
            string expected = "HelloIAm";
            string actual;

            //Act
            list1.Add(a);
            list1.Add(b);
            list1.Add(c);
            list2.Add(d);
            list2.Add(e);
            list2.Add(f);

            TheCustomList<string> result1 = list1 - list2;
            actual = result1.ToString();
            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void OverloadOperatorSubtractIntListsCheckIndex1()
        {
            //Arrange
            TheCustomList<int> list1 = new TheCustomList<int>();
            TheCustomList<int> list2 = new TheCustomList<int>();
            int a = 1;
            int b = 2;
            int c = 3;
            int d = 4;
            int expected = 3;
            int actual;

            //Act
            list1.Add(a);
            list1.Add(b);
            list1.Add(c);
            list1.Add(d);
            list2.Add(a);
            list2.Add(d);

            TheCustomList<int> result1 = list1 - list2;
            actual = result1[1];
            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void OverloadOperatorSubtractListsResultEmptyListCheckIndex0()
        {
            //Arrange
            TheCustomList<int> list1 = new TheCustomList<int>();
            TheCustomList<int> list2 = new TheCustomList<int>();
            int a = 1;
            int expected = 0;
            int actual;

            //Act
            list1.Add(a);
            list2.Add(a);
            TheCustomList<int> result = list1 - list2;
            actual = result[0];
            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
