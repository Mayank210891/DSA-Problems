using System;
namespace LearnToFly.LinkedList
{
    public class DoublyLinkedList
    {
        public Node headNode;
        public int count;
        public DoublyLinkedList()
        {
            headNode = null;
            CreateList();
            //InsertAtBegining(6);
            //InsertAtTheEnd(7);
            InsertionInBetween(10, 3);
            Display();
            Console.ReadLine();
        }

        public class Node
        {
            public int data;
            public Node next;
            public Node prev;

            public Node(int data)
            {
                this.data = data;
                this.prev = null;
                this.next = null;
            }
        }

        public void CreateList()
        {
            Console.Write("Please enter the size of list: ");
            int size = Convert.ToInt32(Console.ReadLine());
            count = size;

            for (int i = 1; i <= size; i++)
            {
                Console.Write("Please enter the value : ");
                int data = Convert.ToInt32(Console.ReadLine());

                Node start;
                Node newNode = new Node(data);
                if (headNode == null)
                {
                    headNode = newNode;
                    //return;
                }
                else
                {
                    start = headNode;

                    while (start.next != null)
                    {
                        start = start.next;
                    }
                    start.next = newNode;
                    newNode.prev = start;
                    
                }
            }
        }

        public void InsertAtBegining(int data)
        {
            Node newNode = new Node(data);
            if(headNode == null)
            {
                headNode = newNode;
            }
            else
            {
                newNode.next = headNode;
                headNode.prev = newNode;
                headNode = newNode;
                // headNode.prev = null;
            }
        }

        public void InsertAtTheEnd(int data)
        {
            Node newNode = new Node(data);
            if(headNode == null)
            {
                headNode = newNode;
                return;
            }
            Node temp = headNode;

            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = newNode;
            newNode.prev = temp;
        }

        public void InsertionInBetween(int data, int postion)
        {
            if(count+1 < postion)
            {
                Console.WriteLine("Position you are looking is not present");
                return;
            }
            Node newNode = new Node(data);
            Node temp = headNode;
            if (headNode == null) { 
                headNode = newNode;
                return;
            }
            for (int i = 1; i < postion-1 && temp != null; i++)
            {
                temp = temp.next;
            }

            if(count+1 == postion)
            {
                newNode.prev = temp;
                temp.next = newNode;
            }
            else
            {
                newNode.next = temp.next;
                newNode.prev = temp;
                temp.next.prev = newNode;
                temp.next = newNode;
            }
            

        }
        
        public void Display()
        {
            Node trav = headNode;
            Node last = null;

            while (trav != null)
            {   
                Console.Write(trav.data + " => ");
                last = trav;
                trav = trav.next;

            }
            Console.WriteLine();

            Console.WriteLine("In reverse Order");

            while (last != null)
            {
                Console.Write(last.data + " => ");
                last = last.prev;

            }
        }

    }
}
