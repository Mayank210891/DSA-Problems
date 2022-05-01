using System;
namespace LearnToFly.LeetCode
{
    public class ReduceToZero
    {
        public ReduceToZero()
        {
        }

        public int Solution(int num)
        {
            int count = 0;
            while(num > 0)
            {
                // for even case
                if(num % 2== 0)
                {
                    num = num / 2;
                    count++;
                }
                // for odd case
                else
                {
                    num = num - 1;
                    count++;
                }
            }
            return count;
        }
    }
}
