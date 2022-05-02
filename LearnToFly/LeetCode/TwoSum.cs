using System;
using System.Collections.Generic;

namespace LearnToFly.LeetCode
{
    public class TwoSum
    {
        public TwoSum()
        {
            int[] data = { 3, 2, 3};
            int sum = 6;
            Solution(data, sum);
        }

        public int[] Solution(int[] nums, int target)
        {
            int[] result = new int[2];
            List<int> list = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (list.Contains(target - nums[i]))
                {
                    result[0] = list.IndexOf(target - nums[i]);
                    result[1] = i;
                    break;
                }
                else
                {
                    list.Add(nums[i]);
                }
            }

            return result;
        }
    
    }
}
