using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingChallenges.Solutions.CodeWars._6kyu
{
    public static class MultiplesOf3Or5Solution
    {
        /*  https://www.codewars.com/kata/514b92a657cdc65150000006/train/csharp
         *  If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
         *
         *  Finish the solution so that it returns the sum of all the multiples of 3 or 5 below the number passed in. Additionally, if the number is negative, return 0 (for languages that do have them).
         *
         *  Note: If the number is a multiple of both 3 and 5, only count it once.
         */
        public static int Solution(int value)
        {
            //multiples of 3 and 5 up to value
            //add all together
            //return sum
            int sum = 0;

            if (value > 0)
            {
                for (int x = 0; x < value; x++)
                {
                    if (x % 3 == 0 || x % 5 == 0)
                    {
                        sum += x;
                    }
                }
            }

            return sum;
        }
    }
}
