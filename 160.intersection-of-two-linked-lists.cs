/*
 * @lc app=leetcode id=160 lang=csharp
 *
 * [160] Intersection of Two Linked Lists
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
                int n1 = GetLength(headA);
        int n2 = GetLength(headB);

        int diff = Math.Abs(n1 - n2);

        if(n1 > n2) headA = MoveNodes(diff, headA);
        else headB = MoveNodes(diff, headB);

        ListNode currA = headA, currB = headB;

        while(currA != null && currB != null) {
            if(currA == currB) return currA;
            currA = currA.next;
            currB = currB.next;
        }

        return null;
    }

    public ListNode MoveNodes(int count, ListNode head) {
        if(count == 0) return head;
        ListNode curr = head;

        while(count > 0) {
            count--;
            curr = curr.next;
        }

        return curr;
    }

    public int GetLength(ListNode head) {
        int count = 0;
        ListNode curr = head;

        while(curr != null) {
            count++;
            curr = curr.next;
        }

        return count;
    }
}
// @lc code=end

