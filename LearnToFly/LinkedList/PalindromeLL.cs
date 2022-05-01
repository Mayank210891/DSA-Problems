using System;
using System.Collections;

namespace LearnToFly.LinkedList
{
    public class PalindromeLL
    {
        public PalindromeLL()
        {
        }

        ListNode start = null;
        public bool IsPalindrome(ListNode head)
        {
            ListNode temp = head;
            ArrayList test = new ArrayList();
            while (temp != null)
            {
                test.Add(temp.val);
                temp = temp.next;
            }

            return true;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
