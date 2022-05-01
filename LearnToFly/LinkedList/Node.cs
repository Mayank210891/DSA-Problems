using System;
namespace LearnToFly.LinkedList
{
    public class Node
    {
        public int data;
        public Node next;

        public Node(int value)
        {
            data = value;
            next = null;
        }

        public void Add(int data)
        {
            //when there is only headnode present
            if (next == null)
            {
                next = new Node(data);
            }
            // when there are more than headnode
            else
            {
                next.Add(data);
            }
        }

        //public void AddSorted(int data)
        //{
        //    if (next == null)
        //    {
        //        next = new Node(data);
        //    }
        //    else if (data < next.data)
        //    {
        //        Node temp = new Node(data);
        //        temp.next = next;
        //        next = temp;
        //    }
        //    else
        //    {
        //        next.AddSorted(data);
        //    }
        //}
    }
}
