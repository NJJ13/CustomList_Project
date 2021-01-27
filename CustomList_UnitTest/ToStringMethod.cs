using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList;

namespace CustomList_UnitTest
{
    [TestClass]
    public class ToStringMethod
    {
        [TestMethod]
        public void ConvertIntToStringInCustomListAtIndex1()
        {
            //Arrange
            TheCustomList<int> list = new TheCustomList<int>();
            int firstNumber = 1;
            int secondNumber = 2;
            string actual;
            string expected = "2";

            //Act
            list.Add(firstNumber);
            list.Add(secondNumber);
            actual = list.ToString(list[1]);
            

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
            string expected = "21";

            //Act
            list.Add(firstNumber);
            list.Add(secondNumber);
            actual = list.ToString(list[1]+list[0]);


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
            string expected = "true";

            //Act
            list.Add(x);
            list.Add(y);
            actual = list.ToString(list[0]);


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
            char char3 = 'l';
            string actual;
            string expected = "cool";

            //Act
            list.Add(char1);
            list.Add(char2);
            list.Add(char3);
            actual = list.ToString(list[0]+ list[1] + list[1] + list[2]);


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
            actual = list.ToString(list[0] + list[1]);


            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
