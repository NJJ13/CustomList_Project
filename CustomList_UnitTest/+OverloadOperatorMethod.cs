using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList;

namespace CustomList_UnitTest
{
    [TestClass]
    public class OverloadAdditionOperatorMethod
    {
        [TestMethod]
        public void OverloadOperatorAddIntLists()
        {
            //Arrange
            TheCustomList<int> list1 = new TheCustomList<int>();
            TheCustomList<int> list2 = new TheCustomList<int>();
            int a = 1;
            int b = 2;
            int c = 3;
            int d = 4;
            int e = 5;
            int f = 6;
            string expected = "123456";
            string actual;

            //Act
            list1.Add(a);
            list1.Add(b);
            list1.Add(c);
            list2.Add(d);
            list2.Add(e);
            list2.Add(f);

            TheCustomList<int> result1 = list1 + list2;
            actual = result1.ToString();
            //Assert
            Assert.AreEqual(expected, actual);
        
        }
        [TestMethod]
        public void OverloadOperatorAddStringLists()
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
            string expected = "HelloIAmANewString";
            string actual;

            //Act
            list1.Add(a);
            list1.Add(b);
            list1.Add(c);
            list2.Add(d);
            list2.Add(e);
            list2.Add(f);

            TheCustomList<string> result1 = list1 + list2;
            actual = result1.ToString();
            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void OverloadOperatorAddIntListsCheckIndexat3()
        {
            //Arrange
            TheCustomList<int> list1 = new TheCustomList<int>();
            TheCustomList<int> list2 = new TheCustomList<int>();
            int a = 1;
            int b = 2;
            int c = 3;
            int d = 4;
            int e = 5;
            int f = 6;
            int expected = 4;
            int actual;

            //Act
            list1.Add(a);
            list1.Add(b);
            list1.Add(c);
            list2.Add(d);
            list2.Add(e);
            list2.Add(f);

            TheCustomList<int> result1 = list1 + list2;
            actual = result1[3];
            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void OverloadOperatorAddEmptyIntListToIntList()
        {
            //Arrange
            TheCustomList<int> expected = new TheCustomList<int>();
            TheCustomList<int> list2 = new TheCustomList<int>();
            
            int a = 1;
            int b = 2;
            int c = 3;
            
            

            //Act
            expected.Add(a);
            expected.Add(b);
            expected.Add(c);
            

            TheCustomList<int> actual = expected + list2;
            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void OverloadOperatorAddEmptyListsCheckIndex0()
        {
            //Arrange
            TheCustomList<int> list1 = new TheCustomList<int>();
            TheCustomList<int> list2 = new TheCustomList<int>();
            int expected = 0;
            int actual;
            
            //Act
            
            TheCustomList<int> result = list1 + list2;
            actual = result[0];
            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
