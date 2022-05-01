using System;
using System.Collections.Generic;

namespace LearnToFly.LeetCode
{
    public class RansomNote
    {
        public RansomNote()
        {
        }

        public bool SolutionOne(string magazine, string ransomNote)
        {
            bool res = false;
            if(magazine.Length < ransomNote.Length)
            {
                return res;
            }
            for(int i = 0; i < ransomNote.Length; i++)
            {
                if (magazine.Contains(ransomNote[i].ToString()))
                {
                    res = true;
                    magazine = magazine.Remove(magazine.IndexOf(ransomNote[i]), 1);
                    ransomNote = ransomNote.Remove(i, 1);
                    i--;
                }
                else
                {
                    res = false;
                    break;
                }
            }

            return res;
        }

        public bool SolutionTwo(string magazine, string ransomNote)
        {
            var dict = new Dictionary<char, int>();
            foreach (var c in magazine)
            {
                if (dict.ContainsKey(c))
                    dict[c]++;
                else
                    dict.Add(c, 1);
            }

            foreach (var c in ransomNote)
            {
                if (dict.ContainsKey(c) && dict[c] > 0)
                    dict[c]--;
                else
                    return false;
            }
            return true;
        }
    }
}
