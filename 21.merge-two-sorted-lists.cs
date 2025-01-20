/*
 * @lc app=leetcode id=21 lang=csharp
 *
 * [21] Merge Two Sorted Lists
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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode dummyNode = new ListNode(-1);
        ListNode curr = dummyNode;

        while(list1 != null || list2 != null) {
            if(list2 == null || (list1 != null && list1.val < list2.val)) {
                curr.next = list1;
                list1 = list1.next; 
            } else {
                curr.next = list2;
                list2 = list2.next;
            }

            curr = curr.next;
        }

        return dummyNode.next;
    }
}
// @lc code=end

