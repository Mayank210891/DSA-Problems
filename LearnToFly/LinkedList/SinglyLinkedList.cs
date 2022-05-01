using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LearnToFly.LinkedList
{
    public class SinglyLinkedList
    {
        public Node headNode;
        public Node tailNode;
        public SinglyLinkedList()
        {
            headNode = null;
            CreateList();
            bool res = IsPalindrome(headNode);
            Console.WriteLine(res);
            //ListTraverse();
            //DisplayList();
            //MiddleNode(headNode);
            //Console.WriteLine("After Midlle node");
            //DisplayList();
            //CountNodes();
            //Console.WriteLine("Please provide value to search");
            //int val = Convert.ToInt16(Console.ReadLine());
            //SearchInList(val);
            //SecondLastNode();
            //FindPredecessorOfANode(3);
            //FindNodeAtParticularPostion(3);
            //InsertionInTheBegining(10);
            //InsertionInTheEmptyList(4);
            //InsertionAtTheEnd(10);
            //InsertionInBetween(4, 10);
            //InsertionAfterANode(3, 10);
            //InsertionBeforeANode(3, 10);
            //DeletionFirstNode();

            // InsertFirst(1);
            // InsertFirst(2);
            // InsertFirst(3);

            Console.ReadLine();


        }
        public void CreateList()
        {
            Console.Write("Please enter the size of list: ");
            int size = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= size; i++)
            {
                Console.Write("Please enter the element to be inserted: ");
                if (headNode == null)
                {
                    headNode = new Node(Convert.ToInt32(Console.ReadLine()));
                }
                else
                {
                    //headNode.Add(Convert.ToInt32(Console.ReadLine()));
                    InsertionAtTheEnd(Convert.ToInt32(Console.ReadLine()));
                }
            }
        }

        public Node MiddleNode(Node head)
        {
            int size = CountNodes(head);
            int position = (size / 2) + 1;
            int middle = 0;

            Node temp = head;

            while (temp != null)
            {
                middle += 1;
                if (middle == position)
                    return temp;

                temp = temp.next;
            }
            return null;
        }

        private int CountNodes(Node head)
        {
            int count = 0;
            if (head == null)
                return 0;

            Node temp = head;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }

            return count;
        }

        public void ListTraverse()
        {
            Node n = headNode;
            while (n != null)
            {
                Console.Write(n.data + "  ");
                n = n.next;
            }
        }

        public void CountNodes()
        {
            int count = 0;
            Node n = headNode;
            while (n != null)
            {
                count++;
                n = n.next;
            }

            Console.WriteLine("Total number of Nodes in list are: {0}", count);
        }

        public void SearchInList(int value)
        {
            int position = 1;
            Node n = headNode;
            while (n != null)
            {
                if (n.data == value)
                {
                    Console.WriteLine("Value found at {0} position", position);
                    break;
                }
                else
                {
                    position++;
                    n = n.next;
                }

            }
            Console.WriteLine("Value is not in the list");
        }

        public void DisplayList()
        {
            Node n = headNode;
            if (n == null)
            {
                Console.Write("List is empty");
                return;
            }
            else
            {
                Console.Write("List is : ");
                while (n != null)
                {
                    Console.Write(n.data + " ");
                    n = n.next;
                }
            }
            Console.WriteLine();

        }

        public void LastNode()
        {
            Node n = headNode;
            while (n.next != null)
            {
                n = n.next;
            }
            Console.WriteLine("Last node data is: {0}", n.data);
        }

        public void SecondLastNode()
        {
            Node n = headNode;
            while (n.next.next != null)
            {
                n = n.next;
            }
            Console.WriteLine("SecondLast node data is : {0}", n.data);
        }

        public void FindPredecessorOfANode(int value)
        {
            Node n = headNode;
            while (n.next != null)
            {
                if (n.data == value)
                {
                    Console.WriteLine("This is head node");
                }
                else if (n.next.data == value)
                {
                    Console.WriteLine("The predecessor of {0}, is {1}", value, n.data);
                }
                n = n.next;
                break;
            }
        }

        public void FindNodeAtParticularPostion(int k)
        {
            Node n = headNode;
            for (int i = 1; i < k && n != null; i++)
            {
                if (n.next != null)
                {
                    n = n.next;
                }
                else
                {
                    Console.WriteLine("List has lesser elements than the postition provided");
                    break;
                }
            }
            Console.WriteLine("{0} is present at location {1}", n.data, k);
        }

        public void InsertionInTheBegining(int data)
        {
            Node n = headNode;
            Node temp = new Node(data);
            temp.next = n;
            headNode = temp;
            Console.WriteLine("++++++++++++==========+++++++++++");
            DisplayList();
        }

        public void InsertionInTheEmptyList(int data)
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            DisplayList();
        }

        public void InsertionAtTheEnd(int data)
        {
            Node n = headNode;
            Node temp = new Node(data);
            if (n == null)
            {
                headNode = temp;
                return;
            }
            while (n.next != null)
            {
                n = n.next;
            }

            n.next = temp;
        }

        public void InsertionInBetween(int k, int value)
        {
            // retest
            Node n = headNode;
            Node temp = new Node(value);
            if (n == null)
            {
                n = temp;
                return;
            }


            for (int i = 1; i < k - 1 && n != null; i++)
            {
                n = n.next;
            }
            temp.next = n.next;
            n.next = temp;
            DisplayList();

        }

        public void InsertionAfterANode(int refNode, int data)
        {
            // retest
            Node n = headNode;
            while (n != null)
            {
                if (n.data == refNode)
                    break;

                n = n.next;

            }
            if (n == null)
                Console.WriteLine("Data is not present in the list");
            else
            {
                Node temp = new Node(data);
                temp.next = n.next;
                n.next = temp;
                DisplayList();
            }

        }

        public void Test(int data, int k)
        {
            Node p = headNode;
            while (p != null)
            {
                if (p.data == k)
                    break;
                p = p.next;
            }
            if (p == null)
                Console.WriteLine(k + "not present in the list");
            else
            {
                Node temp = new Node(data);
                temp.next = p.next;
                p.next = temp;
            }
            DisplayList();
        }

        public void InsertionBeforeANode(int refNode, int data)
        {
            // Retest
            Node n = headNode;
            bool isThere = false;
            while (n.next != null)
            {
                if (n.next.data == refNode)
                {
                    isThere = true;
                    break;
                }
                n = n.next;
            }
            if (isThere)
            {
                Node temp = new Node(data);
                temp.next = n.next;
                n.next = temp;

                DisplayList();
            }
            else
            {
                Console.WriteLine("Ref node is not present in the list");
            }

        }

        public void DeletionFirstNode()
        {
            if (headNode == null)
                Console.WriteLine("List is empty");
            else
            headNode = headNode.next;

            DisplayList();
        }

        public void InsertFirst(int data)
        {
            Node node = new Node(data);
            node.next = headNode;
            headNode = node;

            if(tailNode == null)
            {
                tailNode = headNode;
            }
            
        }

        public bool IsPalindrome(Node head)
        {
            Node temp = head;
            Stack<int> stack = new Stack<int>();
            bool isPalindrome = false;

            while (temp != null)
            {
                stack.Push(temp.data);
                temp = temp.next;
            }

            while (head != null)
            {
                if (head.data == stack.Pop())
                {
                    isPalindrome = true;
                    head = head.next;
                }
                else
                {
                    isPalindrome = false;
                    break;
                }
            }

            return isPalindrome;
        }
    }

}
