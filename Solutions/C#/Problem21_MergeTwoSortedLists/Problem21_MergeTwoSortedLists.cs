using System;
namespace LeetCode.Solutions.Cs.Problem21MergeTwoSortedLists
{
    /// <summary>
    /// Problem #21
    /// "You are given the heads of two sorted linked lists list1 and list2.
    /// 
    /// Merge the two lists in a one sorted list.The list should be made by
    /// splicing together the nodes of the first two lists.
    ///
    /// Return the head of the merged linked list."
    /// 
    /// https://leetcode.com/problems/merge-two-sorted-lists/
    /// </summary>
    public class Problem21MergeTwoSortedLists
    {
        /// <summary>
        /// Runtime complexity: O(2n + n ** 2), which simplifies to O(n**2)
        /// </summary>
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null) { return list2; }
            if (list2 == null) { return list1; }

            int count = 0;
            ListNode currentNode = list1;

            // find the tail of list1
            while (currentNode.next != null)
            {
                currentNode = currentNode.next;
                count++;
            }
            ListNode tail1 = currentNode;

            // add the head of list 2 to the tail of list 1
            tail1.next = list2;

            while (currentNode.next != null)
            {
                currentNode = currentNode.next;
                count++;
            }
            var comparisonNode = list1.next;
            // two approaches: one pass, two pass


            for (int i = 0; i < count; i++)
            {
                currentNode = list1;
                comparisonNode = list1.next;

                // while it's not the tail
                while (currentNode.next != null && comparisonNode != null)
                {
                    if (currentNode.val > comparisonNode.val)
                    {

                        // swap their values
                        int temp = comparisonNode.val;
                        comparisonNode.val = currentNode.val;
                        currentNode.val = temp;
                    }
                    if (comparisonNode != currentNode)
                    {
                        comparisonNode = comparisonNode.next;
                    }
                    currentNode = currentNode.next;
                }
            }
            return list1; // answer
        }
    }
    /// <summary>
    /// Definition for singly-linked list.
    /// </summary>
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
