using System;
using System.ComponentModel;

namespace ListsAndGraphs
{
    class LinkedList
    {
        public Node first { get; }
        public LinkedList(int data)
        {
            first = new Node(data, null);
        }

        public bool append(int data)
        {
            Node finalNode;

            finalNode = this.getLast();
            finalNode.next = new Node(data, finalNode);

            return true;
        }

        private Node getLast()
        {
            Node n;
            n = this.first;
            while(n.next != null)
            {
                n = n.next;
            }
            return n;
        }

        /* This is the destructor */
        ~LinkedList()
        {
            Node n;
            n = this.getLast();
            while (n.previous != null)
            {
                n = n.previous;
                n.next = null;
            }
            n = null;
        }

        public Node findItem(int data)
        {
            Node n;
            n = this.first;
            while(n.next != null)
            {
                if (n.data == data)
                {
                    return n;
                }
            }
            return null;
        }
    }

    class Node
    {
        public int data { get; set; }
        public Node next { get; set; }
        public Node previous { get; set; }
        public Node(int data, Node previous)
        {
            this.data = data;
            this.next = null;
            this.previous = previous;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            LinkedList l;
            Node tmp;

            l = new LinkedList(1);

            l.append(5);
            l.append(10);

            tmp = l.first;
            Console.Out.WriteLine(tmp.data);
            while ((tmp = tmp.next) != null)
                Console.Out.WriteLine(tmp.data);
        }
    }
}