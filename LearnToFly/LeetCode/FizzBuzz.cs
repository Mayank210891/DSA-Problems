using System;
using System.Collections.Generic;

namespace LearnToFly.LeetCode
{
    public class FizzBuzz
    {
        public FizzBuzz()
        {
        }

        public IList<string> Solution(int n)
        {
            string[] arr = new string[n];

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    arr[i-1] = "FizzBuzz";
                }
                else if (i % 3 == 0)
                {
                    arr[i-1] = "Fizz";
                }
                else if (i % 5 == 0)
                {
                    arr[i-1] = "Buzz";
                }
                else
                {
                    arr[i-1] = i.ToString();
                }
            }

            List<string> res = new List<string>();
            int[] items = { 10, 100, 1000 };

            Array.ForEach(arr, element => res.Add(element));

            return res;
        }
    }
}
