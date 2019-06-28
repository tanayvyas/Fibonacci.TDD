using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FibonacciSeries.Tests
{
    [TestClass]
    public class FibonacciTests
    {
        /// <summary>
        /// Fibonacci Series (0, 1, 1, 2, 3, 5, 8, 13, 21, 34, ...)
        /// Using the MStest unit test cases setup here, MStest has datarow feature for 
        /// passing test parameters without needing a seperate test methods with each set of parameters.
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="number"></param>
        [DataTestMethod]
        [DataRow(0, 0)]//Succcess
        [DataRow(1, 1)]//Succcess
        [DataRow(1, 2)]//Succcess
        [DataRow(2, 3)]//Succcess
        //Failed test cases
        //[DataRow(2, 4)]//Failure
        //[DataRow(1, 3)]//Failure
        public void TestFibonacci(int expected, int number)
        {
            var fb = new Fibonacci();
            Assert.AreEqual(expected, fb.GetFibonacci(number));
        }
    }
}
