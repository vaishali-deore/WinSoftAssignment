using System;
using System.Collections.Generic;


namespace LongestSubString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "pwwkew";

            Dictionary<char, int> charIndexMap = new Dictionary<char, int>();
            int maxLength = 0;
            int startIndex = 0;

            for (int endIndex = 0; endIndex < s.Length; endIndex++)
            {
                if (charIndexMap.ContainsKey(s[endIndex]) && charIndexMap[s[endIndex]] >= startIndex)
                {
                    startIndex = charIndexMap[s[endIndex]] + 1;
                }

                charIndexMap[s[endIndex]] = endIndex;

                maxLength = Math.Max(maxLength, endIndex - startIndex + 1);
            }

            Console.WriteLine("Length of the longest substring without repeating characters: " + maxLength);
            Console.ReadLine();

        }
    }
}

/*
 Example 1 ::
Input: s = "abcabcbb"
Length of the longest substring without repeating characters: 3


Example 2 :: 
Input: s = "bbbbb"
Output: Length of the longest substring without repeating characters: 1
 



Example 3 :: 
Input: s = "pwwkew"
Output: Length of the longest substring without repeating characters: 3
 */
