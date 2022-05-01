using System;
namespace LearnToFly.LeetCode
{
    public class RomanToInteger
    {
        public RomanToInteger()
        {
            Console.WriteLine((int)Value.X);
        }

        public void SolutionOne(string s)
        {
            int[] arr = new int[50];
            int res = 0;

            for(int i = 0; i< s.Length; i++)
            {
                switch (s[i])
                {
                    case 'I':
                        arr[i] = (int)Value.I;
                        break;
                    case 'V':
                        arr[i] = (int)Value.V;
                        break;
                    case 'X':
                        arr[i] = (int)Value.X;
                        break;
                    case 'L':
                        arr[i] = (int)Value.L;
                        break;
                    case 'C':
                        arr[i] = (int)Value.C;
                        break;
                    case 'D':
                        arr[i] = (int)Value.D;
                        break;
                    case 'M':
                        arr[i] = (int)Value.M;
                        break;
                }
            }
            for(int i = 0; i < arr.Length-1; i++)
            {
                if(arr[i] < arr[i + 1])
                {
                    res += (arr[i+1] - arr[i]);
                    i++;
                }
                else
                {
                    res += arr[i];
                }
            }
            Console.WriteLine(res);
        }

        public void SolutionTwo(string s)
        {
            int res = 0;
            if (s.Contains("IV"))
            {
                res = +4;
                s = s.Replace("IV", "");
            }
            if (s.Contains("IX"))
            {
                res += 9;
                s = s.Replace("IX", "");
            }
            if (s.Contains("XL"))
            {
                res += 40;
                s = s.Replace("XL", "");
            }
            if (s.Contains("XC"))
            {
                res += 90;
                s = s.Replace("XC", "");
            }
            if (s.Contains("CD"))
            {
                res += 400;
                s = s.Replace("CD", "");
            }
            if (s.Contains("CM"))
            {
                res += 900;
                s = s.Replace("CM", "");
            }
            if (s.Length > 0)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    switch (s[i])
                    {
                        case 'I':
                            res += 1;
                            break;
                        case 'V':
                            res += 5;
                            break;
                        case 'X':
                            res += 10;
                            break;
                        case 'L':
                            res += 50;
                            break;
                        case 'C':
                            res += 100;
                            break;
                        case 'D':
                            res += 500;
                            break;
                        case 'M':
                            res += 1000;
                            break;
                    }
                }
            }


            Console.WriteLine(res);
        }

        

    }

    enum Value
    {
        I = 1,
        V = 5,
        X = 10,
        L = 50,
        C = 100,
        D = 500,
        M = 1000
    }
}
