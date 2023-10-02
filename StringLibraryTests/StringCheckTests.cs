using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using StringLibrary;
using System.Collections.Generic;

namespace StringLibraryTests
{
    [TestClass]
    public class StringCheckTests
    {
        [TestMethod]
        public void GetLetters_AHC_ReturnAHC()
        {
            string textString = "Ананас";
            char[] expected = { 'А', 'Н', 'С' };

            List<char> action = StringCheck.GetLetters(textString);

            CollectionAssert.AreEqual(expected, action);
        }
        [TestMethod]
        public void GetLetters_bo_ReturnBo()
        {
            string textString = "Bob";
            char[] expected = { 'B', 'O' };

            List<char> action = StringCheck.GetLetters(textString);

            CollectionAssert.AreEqual(expected, action);
        }
        [TestMethod]
        public void GetLetters_ABVGD_ReturnABVGD()
        {
            string textString = "дгвба_дгвба";
            char[] expected = { 'А', 'Б', 'В', 'Г', 'Д' };

            List<char> action = StringCheck.GetLetters(textString);

            CollectionAssert.AreEqual(expected, action);
        }

    

        [DataTestMethod]
        [DataRow("дгвба_дгвба",new char[] { 'А', 'Б', 'В', 'Г', 'Д' })]
        public void GetLetters (string text, char[] expected)
        {
            List<char> actual = StringCheck.GetLetters(text);
            CollectionAssert.AreEqual(expected, actual);
        }
        [DataTestMethod]
        [DataRow("123 @#$%^&*()", new char[] {})]
        public void GetLetters1(string text, char[] expected)
        {
            List<char> actual = StringCheck.GetLetters(text);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
