using System;
using System.Collections.Generic;
using LearnToFly.LeetCode;
using LearnToFly.LinkedList;
using LearnToFly.MemoryCollection;
using LearnToFly.SolidPrinciples;
using System.Linq;

namespace LearnToFly
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4 };
            
            Console.WriteLine(arr.Sum());
            List<int> li = new List<int>();
            Stack<int> st = new Stack<int>();
            Queue<int> qu = new Queue<int>();

            for(int i =0; i< 5; i++)
            {
                li.Add(i);
                st.Push(i);
                qu.Enqueue(i);
            }
            for(int j = 0; j< 3; j++)
            {
                li.Remove(j);
                st.Pop();
                qu.Dequeue();
            }


            Console.WriteLine("Hello World!");
            // Linked List
            // 1st approach
            //Node head = new Node(10);
            //Node temp1 = new Node(20);
            //Node temp2 = new Node(30);

            //head.next = temp1;
            //temp1.next = temp2;

            // 2nd approach

            //Node start = new Node(1);
            //start.next = new Node(2);
            //start.next.next = new Node(4);
            //start.Print();

            // 3rd approach
            //SinglyLinkedList head = new SinglyLinkedList();
            //DoublyLinkedList dl = new DoublyLinkedList();

            //=========**********============
            //Matrix m = new Matrix();




            // =========*****************============
            //List<int> interview = new List<int>();
            //for(int i = 1; i <= 100; i++)
            //{
            //    interview.Add(i);
            //}

            //List<int> data = interview.FindAll(x => x > 20 );
            //foreach(int d in data)
            //{
            //    Console.WriteLine(d);
            //}

            // Problem_4
            ReduceToZero r = new ReduceToZero();
            r.Solution(123);

            // Problem_3
            // FizzBuzz f = new FizzBuzz();
            // f.Solution(15);

            // Problem_2
            // RansomNote r = new RansomNote();
            // var res = r.SolutionTwo("ayank", "maya");
            // Console.WriteLine(res);

            // Problem_1
            // RomanToInteger r = new RomanToInteger();
            // r.SolutionTwo("XCIV");
            // =========*****************============

            // using var gc = new GarbageCollection(null);
            // gc.Get();
            // gc.Post("");

            // =========*****************============

            // SOLID Principle
            // Solid s = new Solid();

            Console.ReadLine();

        }
    }
}
