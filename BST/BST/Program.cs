using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{

    class Node
    {
        public int Data;
        public Node Left;
        public Node Right;
        public Node Root;
        public Node()
        {
            this.Data = 0;
            this.Left = null;
            this.Right = null;
            this.Root = null;
        }
        public Node(int a)
        {
            this.Data = a;
            this.Left = null;
            this.Right = null;
            this.Root = null;
        }
        public Node(int a, Node left, Node root)
        {
            this.Data = a;
            this.Left = left;
            this.Right = null;
            this.Root = root;
        }
        public Node(Node right, int a, Node root)
        {
            this.Data = a;
            this.Right = right;
            this.Left = null;
            this.Root = root;
        }
        public Node(int a, Node root)
        {
            this.Data = a;
            this.Right = null;
            this.Left = null;
            this.Root = root;
        }
        public Node(Node right, int a, Node left, Node root)
        {
            this.Data = a;
            this.Right = right;
            this.Left = left;
            this.Root = root;
        }
    }
    class BinarySearchTree
    {
        public Node start;
        public Node end;
        public BinarySearchTree()
        {
            this.start = null;
            this.end = null;
        }
        public BinarySearchTree(BinarySearchTree L)
        {
            this.start = L.start;
            this.end = L.end;
        }
        public void insert(int a)
        {
            if (this.start == null)
            {
                this.start = new Node(a);
            }
            else
            {
                if (a < start.Data)
                {
                    Node itrate = this.start, temp = null;
                    while (itrate != null)
                    {
                        if (a > itrate.Data)
                        {
                            temp = itrate;
                            itrate = itrate.Right;
                        }
                        else
                        {
                            temp = itrate;
                            itrate = itrate.Left;
                        }
                    }
                    if (a > temp.Data)
                    {
                        temp.Right = new Node(a, itrate);
                    }
                    else
                    {
                        temp.Left = new Node(a, itrate);
                    }
                }
                else
                {
                    Node itrate = this.start, temp = null;
                    while (itrate != null)
                    {
                        if (a > itrate.Data)
                        {
                            temp = itrate;
                            itrate = itrate.Right;
                        }
                        else
                        {
                            temp = itrate;
                            itrate = itrate.Left;
                        }
                    }
                    if (a > temp.Data)
                        temp.Right = new Node(a, itrate);
                    else
                        temp.Left = new Node(a, itrate);
                }
            }
        }
        public void Display()
        {
            Node itrate = this.start;
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(itrate);
            while (q.Count > 0)
            {
                Node n = q.Dequeue();
                Console.WriteLine(n.Data);
                if (n.Left != null)
                    q.Enqueue(n.Left);
                if (n.Right != null)
                    q.Enqueue(n.Right);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.insert(70);
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                bst.insert(r.Next(20, 60));
            }
            bst.Display();
        }
    }
}

