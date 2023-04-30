using System;

public class Solution
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        ListNode headDumby = head;
        ListNode prev = null;
        int totalPlace = 0;
        int currentPlace = 0;
        while (head != null)
        {
            totalPlace++;
            head = head.next;
        }
        head = headDumby;
        while (head != null)
        {
            currentPlace++;
            if (totalPlace - n + 1 == currentPlace)
            {
                if (prev == null)
                {
                    return headDumby.next;
                }
                if (prev != null && head.next != null)
                {
                    prev.next = head.next;
                    break;
                }
                if (head.next == null)
                {
                    prev.next = null;
                    break;
                }
            }
            prev = head;
            head = head.next;
        }
        return headDumby;
    }
}