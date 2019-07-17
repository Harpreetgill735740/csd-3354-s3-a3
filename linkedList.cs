using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new LinkedList();
            a.CreateLinkedList();
        }
    }
    class LinkedList
    {
        Node Head, Orange, Tangerine, Tail;
        public void CreateLinkedList()
        {
            Head = new Node();
            Orange = new Node();
            Tangerine = new Node();
            //Tail = new Node();
            Head.next = Orange;
            Console.WriteLine("Yeah!!!");
            Console.Read();
        }
    }

    class Node
    {
        public string studentName;
        public Node next;
        public Node prev;

    }
}
