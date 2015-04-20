﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDDPalindrome.Test
{
    [TestClass]
    public class PalindromeTests
    {
        private PalindromeFinder _palindromeFinder = null;

        [TestInitialize]
        public void InitTest()
        {
            _palindromeFinder = new PalindromeFinder();
        }

        #region Positive Cases
        [TestMethod]
        public void IsPalindromeReturnTrue()
        {
            //Arrange
            string value = "rotator";
            bool expected = true;

            //Act
            bool actual = _palindromeFinder.IsPalindrome(value);

            //Assert
            Assert.AreEqual(expected, actual);


        }
        #endregion Positive Cases

        #region Negative Cases
        [TestMethod]
        public void IsPalindromeReturnFalse()
        {
            //Arrange
            string value = "raggartangenter";
            bool expected = false;

            //Act
            bool actual = _palindromeFinder.IsPalindrome(value);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        //[ExpectedException(typeof(ArgumentNullException))]
        public void IsPalindromeThrowsArgumentNullException()
        {
            //Arrange
            string value = null;
            try
            {
                //Act
                bool actual = _palindromeFinder.IsPalindrome(value);

                // If no exception is thrown, then it fails.
                Assert.Fail("Expected ArgumentNullException");

            }
            catch (ArgumentNullException)
            {

                //This is what should happen. No fail.
            }
            catch
            {
                // If another exception is trhown, then it fails.
                Assert.Fail("Expected ArgumentNullException");

            }



        }

        [TestMethod]
        //[ExpectedException(typeof(ArgumentException))]
        public void IsPalindromeThrowsArgumentException()
        {
            //Arrange
            string value = "a";

            try
            {
                //Act
                bool actual = _palindromeFinder.IsPalindrome(value);

                // If no exception is thrown, then it fails.
                Assert.Fail("Expected ArgumentException");

            }
            catch (ArgumentException)
            {

                //This is what should happen. No fail.
            }
            catch
            {
                // If another exception is trhown, then it fails.
                Assert.Fail("Expected ArgumentException");

            }
        }



        #endregion Negative Cases
    }
}
