using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorldNomadsTest.Controllers;
using System.Collections.Generic;

namespace WNUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAllNumbers()
        {
            int n = 5;
            List<int> expectedList = new List<int> {0,1,2,3,4,5};
            HomeController hc = new HomeController();
            var allNum = hc.AllNumbers(n);
            CollectionAssert.AreEqual(expectedList, allNum);
        }

        [TestMethod]
        public void TestAllOddNumbers()
        {
            int n = 5;
            List<int> expectedList = new List<int> { 1, 3, 5 };
            HomeController hc = new HomeController();
            var allNum = hc.AllOddNumbers(n);
            CollectionAssert.AreEqual(expectedList, allNum);
        }

        [TestMethod]
        public void TestAllEvenNumbers()
        {
            int n = 5;
            List<int> expectedList = new List<int> { 0,2,4 };
            HomeController hc = new HomeController();
            var allNum = hc.AllEvenNumbers(n);
            CollectionAssert.AreEqual(expectedList, allNum);
        }

        [TestMethod]
        public void TestAllNumbersWithLetters()
        {
            int n = 5;
            List<string> expectedList = new List<string> { "0", "1", "2", "C", "4", "E" };
            HomeController hc = new HomeController();
            var allNum = hc.AllNumbersMultiple(n);
            CollectionAssert.AreEqual(expectedList, allNum);
        }

        [TestMethod]
        public void TestFibonacci()
        {
            int n = 5;
            List<int> expectedList = new List<int> { 0,1,1,2,3 };
            HomeController hc = new HomeController();
            var allNum = hc.Fibonacci(n);
            CollectionAssert.AreEqual(expectedList, allNum);
        }
    }
}
