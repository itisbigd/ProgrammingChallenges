using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingChallenges.Solutions.Easy
{
    /* https://leetcode.com/problems/counting-words-with-a-given-prefix/
     *  
     *  You are given an array of strings words and a string pref.

        Return the number of strings in words that contain pref as a prefix.

        A prefix of a string s is any leading contiguous substring of s.
     */
    public static class CountingWordsWithAGivenPrefix
    {
        public static int PrefixCount(string[] words, string pref)
        {
            int numberOfWords = 0;

            foreach(string word in words)
            {
                if (word.StartsWith(pref))
                {
                    numberOfWords++;
                }
            }

            return numberOfWords;
        }
    }
}
