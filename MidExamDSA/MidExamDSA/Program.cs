using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidExamDSA
{
    public class Node
    {
        public Object Element;
        public Node Link;
        public Node()
        {
            Element = null;
            Link = null;
        }
        public Node(Object input_element)
        {
            Element = input_element;
            Link = null;
        }
    }
    public class LinkedList
    {
        public Node header;
        public LinkedList()
        {
            header = new Node();
        }
        private Node Find(Object item)
        {
            Node current = new Node();
            current = header;
            while (current.Element != item)
                current = current.Link;
            return current;
        }
        public void InsertatTop(Object new_item)
        {
            Node current = new Node();
            Node newNode = new Node(new_item);
            current = Find(null);
            newNode.Link = current.Link;
            current.Link = newNode;
        }
        public void InsertatMiddel(Object new_item, Object after)
        {
            Node current = new Node();
            Node newNode = new Node(new_item);
            current = Find(after);
            newNode.Link = current.Link;
            current.Link = newNode;
        }
        public void InsertatBottom(Object new_item, Object after)
        {
            Node current = new Node();
            Node newNode = new Node(new_item);
            current = Find(after);
            newNode.Link = current.Link;
            current.Link = newNode;
        }
        private Node FindPrevious(Object n)
        {
            Node current = header;
            while (!(current.Link == null) && (current.Link.Element != n))
                current = current.Link;
            return current;
        }
        public void Remove(Object n)
        {
            Node p = FindPrevious(n);
            if (!(p.Link == null))
                p.Link = p.Link.Link;
        }
        public void PrintList()
        {
            Node current = new Node();
            current = header;
            while (!(current.Link == null))
            {
                Console.Write(current.Link.Element + ", ");
                current = current.Link;
            }
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            char op1;
            Console.WriteLine("What do you want:\n 1) Insertion\n 2) Deletion");
            op1 = Convert.ToChar(Console.ReadLine());
            if (op1 == '1')
            {
                Console.WriteLine("Insert at Top :\n");
                list.InsertatTop("23");
                list.InsertatTop("12");
                list.InsertatTop("42");
                list.InsertatTop("43");
                list.InsertatTop("46");
                list.PrintList();
                Console.WriteLine("Insert at Middel :\n");
                list.InsertatMiddel("18", "12");
                list.InsertatMiddel("28", "23");
                list.PrintList();
                Console.WriteLine("Insert at bottom :\n");
                list.InsertatBottom("48", "28");
                list.InsertatBottom("50", "48");
                list.PrintList();
            }
            if (op1 == '2')
            {
                list.InsertatBottom("23", null);
                list.InsertatBottom("21", "23");
                list.InsertatBottom("42", "21");
                list.InsertatBottom("14", "42");
                list.InsertatBottom("83", "14");
                list.PrintList();
                Console.WriteLine("Removing 14");
                list.Remove("14");
                list.PrintList();
                Console.WriteLine("Removing 21");
                list.Remove("21");
                list.PrintList();

            }
            else
            {
                Console.WriteLine("Invalid!");
            }
            Console.Read();

        }
    }
}
