/*
 * @lc app=leetcode id=83 lang=csharp
 *
 * [83] Remove Duplicates from Sorted List
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
        ListNode curr = head;

        while(curr != null && curr.next != null) {
            if(curr.val == curr.next.val) {
                curr.next = curr.next.next;
            }
            else {
                curr = curr.next;
            }     
        }

        return head;
    }
}
// @lc code=end

