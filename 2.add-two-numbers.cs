/*
 * @lc app=leetcode id=2 lang=csharp
 *
 * [2] Add Two Numbers
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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode curr1 = l1, curr2 = l2;
        ListNode result = new ListNode(-1);
        ListNode curr = result;
        int carry = 0;

        while(curr1 != null || curr2 != null || carry != 0) {
            var sum = 0;
            if(curr1 != null) {
                 sum += curr1.val;
                 curr1 = curr1.next;
            }

            if(curr2 != null) {
                sum += curr2.val;
                curr2 = curr2.next;
            }

            sum += carry;
            carry = sum / 10;
            curr.next = new ListNode(sum % 10);
            curr = curr.next;
        }

        return result.next;
    }
}
// @lc code=end

