using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingChallenges
{
    /*  https://leetcode.com/problems/sort-array-by-parity/
     *  
     *  Given an integer array nums, move all the even integers at the beginning of the array followed by all the odd integers.
     */
    public static class SortArrayByParitySolution
    {

        public static int[] SortArrayByParity(int[] nums)
        {
            int numberOfEvens = 0;
            int numberOfOdds = 0;
            int[] returnArray = new int[nums.Length];

            foreach (int num in nums)
            {
                if (num % 2 == 0)
                {
                    returnArray[numberOfEvens] = num;
                    numberOfEvens++;
                }
                else
                {
                    returnArray[nums.Length - numberOfOdds] = num;
                    numberOfOdds++;
                }
            }

            return returnArray;
        }
        //public static int[] SortArrayByParity(int[] nums)
        //{
        //    //O(2n)
        //    LinkedList<int> linkedList = new LinkedList<int>();

        //    foreach (int num in nums)
        //    {
        //        if(num % 2 == 0)
        //        {
        //            linkedList.AddFirst(new LinkedListNode<int>(num));
        //        }
        //        else
        //        {
        //            linkedList.AddLast(new LinkedListNode<int>(num));
        //        }
        //    }

        //    linkedList.CopyTo(nums, 0);

        //    return nums;
        //}
    }
}
