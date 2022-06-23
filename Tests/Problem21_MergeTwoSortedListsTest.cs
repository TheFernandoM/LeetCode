using System;
using LeetCode.Solutions.Cs.Problem21MergeTwoSortedLists;
using LeetCode.Solutions.Cs.Problem27RemoveElement;
using LeetCode.Solutions.Cs.Problem9PalindromeNumber;
using Xunit;

namespace LeetCode.Tests
{
    public class Problem21MergeTwoSortedListsTest
    {
        public Problem21MergeTwoSortedListsTest()
        {

        }
        Problem21MergeTwoSortedLists solver = new Problem21MergeTwoSortedLists();

        /// <summary>
        /// Normal test case (base case)
        /// </summary>
        [Fact]
        public void BaseCaseTest()
        {
            // list1 = [1,2,4] 
            var l1_n3 = new ListNode(4);
            var l1_n2 = new ListNode(2, l1_n3);
            var l1_n1 = new ListNode(1, l1_n2);

            // list2 = [1,3,4]
            var l2_n3 = new ListNode(4);
            var l2_n2 = new ListNode(3, l2_n3);
            var l2_n1 = new ListNode(1, l2_n2);

            // Arrange & Act
            var currentNode = solver.MergeTwoLists(l1_n1, l2_n1);

            // Assert
            // answer should be: [1,1,2,3,4,4]
            int[] correctAnswers = new int[] { 1, 1, 2, 3, 4, 4 };
            foreach(int correctAnswer in correctAnswers)
            {
                Assert.Equal(correctAnswer, currentNode.val);
                if(currentNode.next != null) GotoNextNode(ref currentNode);

            }
        }

        /// <summary>
        /// Test case: Both ListNodes are empty
        ///
        /// WARNING: According to LeetCode this should return null
        /// </summary>
        [Fact]
        public void BothListsAreEmptyTest()
        {

            // Arrange & Act
            ListNode node1 = null;
            ListNode node2 = null;

            // Assert (answer should be null)
            ListNode answer = solver.MergeTwoLists(node1, node2);
            Assert.Null(answer);
        }
        /// <summary>
        /// Test case: Both ListNodes are empty
        /// </summary>
        [Fact]
        public void EmptyListAndZeroListTest()
        {

            // Arrange & Act
            ListNode node1 = null;
            var node2 = new ListNode(0);

            // Assert (answer should be null)
            var answer = solver.MergeTwoLists(node1, node2);
            Assert.Equal(0, answer.val);
            Assert.Null(answer.next);
        }

        private ListNode GotoNextNode(ref ListNode currentNode)
        {
            currentNode = currentNode.next;
            return currentNode.next;
        }
    }
}
