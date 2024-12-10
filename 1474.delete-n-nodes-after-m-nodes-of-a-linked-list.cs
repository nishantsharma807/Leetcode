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
    public ListNode DeleteNodes(ListNode head, int m, int n) {
        int skipCounter = m, deleteCounter = n;
        ListNode curr = head;
        ListNode last = head;

        while(curr != null) {
            if(skipCounter > 0)  {
                skipCounter--;
                last = curr;
            }
            else {
                if(deleteCounter > 0) {
                    deleteCounter--;
                    last.next = curr.next;
                }
            }

            if(skipCounter == 0 && deleteCounter == 0) {
                skipCounter = m;
                deleteCounter = n;
            }

            curr = curr.next;
        }
        return head;
    }
}