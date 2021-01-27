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
        public void ConvertIntToStringInCustomList_MultipleInts()
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
    }
}
