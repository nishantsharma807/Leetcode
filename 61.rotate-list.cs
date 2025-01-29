/*
 * @lc app=leetcode id=61 lang=csharp
 *
 * [61] Rotate List
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
    public ListNode RotateRight(ListNode head, int k) {
        if(head == null || head.next == null) return head;

        ListNode curr = head, tail = head;
        int length = 1;

        while(tail.next != null) {
            length++;
            tail = tail.next;
        }
        
        if(k % length == 0) return head;        
        
        int rotations = k % length;        
        int newTailIndex = length - rotations;
        tail.next = curr;
        
        while(curr != null) {
            newTailIndex--;
            if(newTailIndex == 0) break;
            curr = curr.next;
        }

        head = curr.next;
        curr.next = null;

        return head;
    }
}
// @lc code=end

