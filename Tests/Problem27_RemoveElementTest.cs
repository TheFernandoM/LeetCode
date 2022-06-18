using System;
using LeetCode.Solutions.Cs.Problem27RemoveElement;
using LeetCode.Solutions.Cs.Problem9PalindromeNumber;
using Xunit;

namespace LeetCode.Tests
{
    public class Problem27RemoveElementTest
    {
        public Problem27RemoveElementTest()
        {

        }
        Problem27RemoveElement solver = new Problem27RemoveElement();

        /// <summary>
        /// Normal test case (base case)
        /// </summary>
        [Fact]
        public void BaseCaseTest()
        {
            // Arrange & Act
            int[] nums = new int[4]{ 3, 2, 2, 3 };
            int val = 3;

            var answer = solver.RemoveElement(nums, val);

            // Assert
            Assert.Equal(2, answer);
            Assert.Equal(2, nums[0]);
            Assert.Equal(2, nums[1]);

        }

        /// <summary>
        /// Normal test case (base case)
        /// </summary>
        [Fact]
        public void BaseCaseTest2()
        {
            // Arrange & Act
            int[] nums = new int[8] { 0, 1, 2, 2, 3, 0, 4, 2 };
            int val = 2;

            var answer = solver.RemoveElement(nums, val);

            // Assert
            Assert.Equal(5, answer); // assert answer is correct

            // assert the value of the first two indices
            // (this isn't really necessary though since the problem does not
            // care about the positions of the numbers, they can be changed
            Assert.Equal(0, nums[0]);
            Assert.Equal(1, nums[1]);

        }
    }
}
