/*
 * @lc app=leetcode id=234 lang=csharp
 *
 * [234] Palindrome Linked List
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
    public bool IsPalindrome(ListNode head) {
        ListNode slow = head, fast = head;

        while(fast.next != null && fast.next.next != null) 
        {
            slow = slow.next;
            fast = fast.next.next;
        }
        
        ListNode secondHead = ReverseLinkedList(slow.next);

        while(secondHead != null) {
            if(head.val != secondHead.val) return false;
            head = head.next;
            secondHead = secondHead.next;
        }

        return true;
    }

    public ListNode ReverseLinkedList(ListNode head) {
        ListNode curr = head, prev = null;

        while(curr != null) {
            ListNode next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }

        return prev;
    }
}
// @lc code=end

