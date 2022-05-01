using System;
using System.Collections.Generic;
using System.Linq;
namespace LearnToFly.LeetCode
{
    public class Matrix
    {
        public Matrix()
        {
            //OneDimensionalArray();
            //TwoDimensionalArray();
            JaggedArray();
        }

        public void OneDimensionalArray()
        {
            Console.WriteLine("Please enter the size of array");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] OneDAray = new int[size];
            for (int i = 0; i < size; i++)
            {
                OneDAray[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (int i in OneDAray)
            {
                Console.WriteLine(i);
            }

        }

        public void TwoDimensionalArray()
        {
            Console.WriteLine("Please enter row size of array");
            int rowSize = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter col size of array");
            int colSize = Convert.ToInt32(Console.ReadLine());

            int[,] TwoDArray = new int[rowSize, colSize];

            for (int i = 0; i < rowSize; i++)
            {
                Console.WriteLine("Please enter values in row {0}", i);
                for (int j = 0; j < colSize; j++)
                {
                    TwoDArray[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }

            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < colSize; j++)
                {

                    Console.Write(TwoDArray[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        public void JaggedArray()
        {
            int k = 17;
            int[][] jaggedArray = new int[19][]  {
                new int[22] {1,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0},
                new int[22] {1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0},
                new int[22] {1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                new int[22] {1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                new int[22] {1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                new int[22] {1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                new int[22] {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0},
                new int[22] {1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                new int[22] {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0},
                new int[22] {1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0},
                new int[22] {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                new int[22] {1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                new int[22] {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                new int[22] {1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0},
                new int[22] {1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                new int[22] {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                new int[22] {1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                new int[22] {1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0},
                new int[22] {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}

            };

            int[] res = KWeakestRows(jaggedArray, k);
            int[] sorted = new int[5];

            for (int i = 0; i < 5; i++)
            {
                sorted[i] = jaggedArray[i].Count(x => x == 1);
                Console.WriteLine(jaggedArray[i].Count(x => x == 1));
            }

            Console.WriteLine("=========");

            List<Prob> l = new List<Prob>();
            for (int i = 0; i < sorted.Length; i++)
            {
                l.Add(new Prob(i, sorted[i]));
            }

            l.Sort((a, b) => a.Value.CompareTo(b.Value));

            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine(l[i].Position);
            }

        }

        public int[] KWeakestRows(int[][] mat, int k)
        {
            int[] sorted = new int[mat.Length];
            for (int i = 0; i < mat.Length; i++)
            {
                sorted[i] = mat[i].Count(x => x == 1);
            }

            int[] res = new int[k];
            int j = 0;
            while (j != k)
            {
                int min = 0;
                for (int i = 0; i < sorted.Length; i++)
                {
                    if (sorted[min] > sorted[i])
                        min = i;
                }
                res[j] = min;
                sorted[min] = 101;
                j++;
            }
            return res;

            //int[] sorted = new int[mat.Length];
            //for (int i = 0; i < mat.Length; i++)
            //{
            //    sorted[i] = mat[i].Count(x => x == 1);
            //}

            //List<Prob> l = new List<Prob>();
            //for (int i = 0; i < sorted.Length; i++)
            //{
            //    l.Add(new Prob(i, sorted[i]));
            //}
            //var test = l.OrderBy(x => x.Value).ToList();

            //int[] finalRes = new int[k];
            //for (int i = 0; i < k; i++)
            //{
            //    finalRes[i] = test[i].Position;
            //}

            //return finalRes;

        }
        static int count(int i, int[][] mat)
        {
            int low = 0;
            int high = mat[0].Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (mat[i][mid] == 0)
                    high = mid - 1;
                else
                    low = mid + 1;
            }
            return low;
        }
    }

    public class Prob
    {
        public int Position { get; set; }
        public int Value { get; set; }

        public Prob(int position, int value)
        {
            this.Position = position;
            this.Value = value;
        }
    }
}
