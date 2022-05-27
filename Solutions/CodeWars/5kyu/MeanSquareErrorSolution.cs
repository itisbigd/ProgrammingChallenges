using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingChallenges.Solutions.CodeWars._5kyu
{
    public static class MeanSquareErrorSolution
    {
        //https://www.codewars.com/kata/51edd51599a189fe7f000015/csharp
        //        Complete the function that

        //accepts two integer arrays of equal length
        //compares the value each member in one array to the corresponding member in the other
        //squares the absolute value difference between those two values
        //and returns the average of those squared absolute value difference between each member pair.
        public static double Solution(int[] firstArray, int[] secondArray)
        {
            double result = 0;
            for (int x = 0; x < firstArray.Length; x++)
            {
                result += Math.Pow(firstArray[x] - secondArray[x], 2);
            }

            return result / firstArray.Length;
        }
    }
}
