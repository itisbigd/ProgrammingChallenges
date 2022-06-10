using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingChallenges.Solutions.Easy
{
    public static class MergeTwoSortedListsSolution
    {

        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            //insertion sort
            while (list2 != null)
            {
                bool placed = false;
                ListNode currentNode = list1;
                while (!placed)
                {
                    if (currentNode.val <= list2.val && currentNode.next.val > list2.val)
                    {

                    }
                }
            }
            //while loop
            //minheap
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
