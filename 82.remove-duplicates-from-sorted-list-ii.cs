/*
 * @lc app=leetcode id=82 lang=csharp
 *
 * [82] Remove Duplicates from Sorted List II
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
    public ListNode DeleteDuplicates(ListNode head) {
        ListNode result = new ListNode(-1, head);
        ListNode prev = result, curr = head;

        while(curr != null && curr.next != null) {
            if(curr.val != curr.next.val) {
                prev = curr;
                curr = curr.next;
            }
            else {
                while(curr.next != null && curr.val == curr.next.val) {
                    curr = curr.next;
                }
                curr = curr.next;
                prev.next = curr;
            }
        }

        return result.next;
    }
}
// @lc code=end

