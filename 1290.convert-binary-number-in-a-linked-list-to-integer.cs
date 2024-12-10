/*
 * @lc app=leetcode id=1290 lang=csharp
 *
 * [1290] Convert Binary Number in a Linked List to Integer
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public int GetDecimalValue(ListNode head) {
        int result = 0, counter = 0;
        ListNode curr = Reverse(head);

        while(curr != null) {
            result += (int)Math.Pow(2, counter) * curr.val;
            counter++;
            curr = curr.next;
        }

        return result;
    }

    public ListNode Reverse(ListNode head) {
        ListNode curr = head, prev = null;

        while(curr != null) {
            var next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }

        return prev;
    }
}
// @lc code=end

