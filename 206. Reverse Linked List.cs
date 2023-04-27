using System;
//recursive solution
public class Solution {
    public ListNode ReverseList(ListNode head, ListNode prev = null) {
        if(head == null)
        {
            return prev;
        }
        ListNode next = head.next;
        head.next = prev;
        return ReverseList(next, head);
    }
}
//iterative solution
public class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        ListNode prev = null;
        while (head != null)
        {
            ListNode next = head.next;
            head.next = prev;
            prev = head;
            head = next;
        }
        return prev;
    }
}