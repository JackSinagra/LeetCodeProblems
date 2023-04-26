using System;

//intital solution
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
public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {

        ListNode dummyHead = new ListNode(0);
        ListNode cur = dummyHead;
        int carry = 0;
        int total = 0;
        int curval = 0;
        bool inbounds = true;
        while (inbounds == true)
        {

            if (l1 != null && l2 != null)
            {
                total = l1.val + l2.val + carry;
                carry = total / 10;
                curval = total % 10;
                l1 = l1.next;
                l2 = l2.next;
            }
            else if (l1 != null && l2 == null)
            {
                total = l1.val + carry;
                carry = total / 10;
                curval = total % 10;
                l1 = l1.next;

            }
            else if (l2 != null && l1 == null)
            {
                total = l2.val + carry;
                carry = total / 10;
                curval = total % 10;
                l2 = l2.next;
            }
            else if (carry != 0)
            {
                curval = carry;
                carry = 0;
            }
            else
            {
                inbounds = false;
                break;
            }
            cur.next = new ListNode(curval);
            cur = cur.next;
        }
        return dummyHead.next;
    }
}


// final optimized solution
public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        //initialize empty linked lists and carry value
        ListNode dummyHead = new ListNode(0);
        ListNode cur = dummyHead;
        int carry = 0;
        //determines if the end of each list and the carry value are not finished
        while (l1 != null || l2 != null || carry != 0)
        {
            //calculates the value for the current entry into the output linked list, obainting overflow for next entry
            int total = (l1 != null ? l1.val : 0) + (l2 != null ? l2.val : 0) + carry;
            carry = total / 10;
            int curval = total % 10;
            //if end of list hasn't been reached continue to next entry
            if (l1 != null)
            {
                l1 = l1.next;
            }
            if (l2 != null)
            {
                l2 = l2.next;
            }
            //constructs output list from values
            cur.next = new ListNode(curval);
            cur = cur.next;
        }
        //returns solution for question
        return dummyHead.next;
    }
}