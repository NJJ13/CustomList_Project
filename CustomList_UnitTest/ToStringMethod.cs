using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList;

namespace CustomList_UnitTest
{
    [TestClass]
    public class ToStringMethod
    {
        [TestMethod]
        public void ConvertIntToStringInCustomList()
        {
            //Arrange
            TheCustomList<int> list = new TheCustomList<int>();
            int firstNumber = 1;
            string actual;
            string expected = "1";

            //Act
            list.Add(firstNumber);
            actual = list.ToString();
            

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ConvertIntToStringInCustomList_MultipleIntsAtIndex1And0()
        {
            //Arrange
            TheCustomList<int> list = new TheCustomList<int>();
            int firstNumber = 1;
            int secondNumber = 2;
            string actual;
            string expected = "12";

            //Act
            list.Add(firstNumber);
            list.Add(secondNumber);
            actual = list.ToString();


            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ConvertBoolToStringInCustomList_AtIndex0()
        {
            //Arrange
            TheCustomList<bool> list = new TheCustomList<bool>();
            bool x = true;
            bool y = false;
            string actual;
            string expected = "truefalse";

            //Act
            list.Add(x);
            list.Add(y);
            actual = list.ToString();


            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ConvertCharToStringInCustomList_AtMultipleIndexes()
        {
            //Arrange
            TheCustomList<char> list = new TheCustomList<char>();
            char char1 = 'c';
            char char2 = 'o';
            char char3 = 'o';
            char char4 = 'l';
            string actual;
            string expected = "cool";

            //Act
            list.Add(char1);
            list.Add(char2);
            list.Add(char3);
            list.Add(char4);
            actual = list.ToString();


            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ConvertStringToStringInCustomListTwoStringsToOneString()
        {
            //Arrange
            TheCustomList<string> list = new TheCustomList<string>();
            string a = "hello";
            string b = "World";
            string actual;
            string expected = "helloWorld";

            //Act
            list.Add(a);
            list.Add(b);
            actual = list.ToString();


            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
