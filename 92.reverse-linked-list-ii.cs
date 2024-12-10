/*
 * @lc app=leetcode id=92 lang=csharp
 *
 * [92] Reverse Linked List II
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
    public ListNode ReverseBetween(ListNode head, int left, int right) {
        ListNode result = new ListNode(-1, head);
        ListNode curr = head, prev = null;
        ListNode revCurr = result;

        //Move to starting point
        for(int i = 0; i < left - 1; i++) {
            curr = curr.next;
            revCurr = revCurr.next;
        }

        ListNode subListHead = curr;
        ListNode revPrev = null;

        //Reversal
        for(int i = 0; i <= right - left; i++) {
            var revNext = curr.next;
            curr.next = revPrev;
            revPrev = curr;
            curr = revNext;
        }
        
        //Add missing links
        revCurr.next = revPrev;
        subListHead.next = curr;

        return result.next;
    }
}
// @lc code=end

