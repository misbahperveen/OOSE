using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_QUIZ2_CHECKING
{
    class LinkList
    {
        public Node start;
        public LinkList()
        {

            start = new Node();
        }
        public void insertAtBegin(string a, int b)
        {
            if (start.next == null)
            {
                start.next = new Node(a, b);

            }
            else
            {
                Node temp = start.next;
                start.next = new Node(a, b);
            }
        }

        public void insertAtEnd(string a, int b)
        {
            if (start.next == null)
            {
                start.next = new Node(a, b);
            }
            else
            {
                Node temp = start;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                if (temp.next == null)
                {
                    temp.next = new Node(a, b);
                }
            }
        }



        public void dispaly()
        {
            Node temp = start;
            if (start == null)
            {
                Console.WriteLine("Already Empty list");
            }
            else if (start != null)
            {
                while (temp.next != null)
                {
                    Console.WriteLine(temp.data + temp.price);
                    temp = temp.next;
                }
                if (temp.next == null && temp.data != null)
                {
                    Console.WriteLine(temp.data + temp.price);
                }
            }
        }




        class Node
        {
            public Node next;
            public string data;
            public int price;
            public Node()
            {
                next = null;
                data = null;
                price = price;
            }
            public Node(string data, Node next)
            {
                this.data = data;
                this.next = next;
                this.price = price;

            }
            public Node(string data, int price)
            {
                this.data = data;
                this.next = null;
                this.price = price;

                Console.WriteLine("displaying price in descending order");
            }

        }
        class Program
        {
            static void Main(string[] args)
            {
                LinkList l = new LinkList();
                l.insertAtBegin("Pencil", 10);
                l.insertAtEnd("Scale", 5);
                l.insertAtEnd("Eraser", 15);
                l.dispaly();
                Console.ReadKey();
            }
        }
    }

}
