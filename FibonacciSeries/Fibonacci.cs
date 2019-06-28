using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeries
{
    public class Fibonacci
    {
        static void Main(string[] args)
        {
        }
        /// <summary>
        /// Get Fibonacci Series by passing a integer value
        /// </summary>
        /// <param name="number">Number</param>
        /// <returns></returns>
        public int GetFibonacci(int number)
        {
            if (number == 0) return 0;
            if (number == 1) return 1;

            return GetFibonacci(number - 1) + GetFibonacci(number - 2);
        }
    }
}
