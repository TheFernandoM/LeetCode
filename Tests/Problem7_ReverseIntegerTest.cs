using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Solutions.Cs.Problem4MedianOfTwoSortedArrays;
using LeetCode.Solutions.Cs.Problem7ReverseInteger;
using Xunit;

namespace LeetCode.Tests
{
    public class Problem7ReverseIntegerTest
    {
        private Problem7ReverseInteger solver = new Problem7ReverseInteger();

        /// <summary>
        /// Normal test case (base case)
        /// </summary>
        [Fact]
        public void BaseCase()
        {
            // Arrange & Act
            int input = 123;
            var answer = solver.Reverse(input);

            // Assert
            Assert.Equal(321, answer);
        }
        [Fact]
        public void BaseCase_NegativeInteger()
        {
            // Arrange & Act
            int input = -123;
            var answer = solver.Reverse(input);

            // Assert
            Assert.Equal(-321, answer);
        }
    }
}
