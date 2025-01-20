/*
 * @lc app=leetcode id=25 lang=csharp
 *
 * [25] Reverse Nodes in k-Group
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
    public ListNode ReverseKGroup(ListNode head, int k) {
        ListNode curr = head, prevNode = null, nextNode = null;

        while(curr != null) {
            var kthNode = FindKthNode(curr, k);

            if(kthNode == null) {
                if(prevNode != null) prevNode.next = curr;
                break;
            } else {
                nextNode = kthNode.next;
                kthNode.next = null;
                var revHead = Reverse(curr);

                if(curr == head) {
                    head = revHead;
                } else {
                    prevNode.next = kthNode;
                }

                prevNode = curr;
                curr = nextNode;
            }
        }

        return head;
    }

    private ListNode Reverse(ListNode head) {
        ListNode curr = head, prev = null;

        while(curr != null) {
            var next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }

        return prev;
    }

    private ListNode FindKthNode(ListNode head, int k) {
        ListNode curr = head;
        int counter = 0;

        while(curr != null) {
            counter++;
            if(counter == k) break;
            curr = curr.next;
        }

        return counter == k ? curr : null;
    }
}
// @lc code=end

