using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class LinkedList
    {
        public Node head;

        public void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
                this.head = node;
            else
            {
                Node temp = head;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into linkedlist", node.data);
        }

        public void insertLast(int new_data)
        {
            Node new_node = new Node(new_data);
            if (this.head == null)
                this.head = new_node;
            else
            {
                Node lastNode = GetLastNode();
                lastNode.next = new_node;

            }
            Console.WriteLine("inserted into list" + new_node.data);
        }
        public Node GetLastNode()
        {
            Node temp = this.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        internal void Display()
        {
            Node temp = this.head;
            if(temp == null)
            {
                Console.WriteLine("Linked list is empty!");
            }
            else
            {
                while (temp.next != null)
                {
                    Console.WriteLine(temp.data + "->");
                    temp = temp.next;
                }
                Console.WriteLine(temp.data);

            }
        }

        public void insertFront(int new_data)
        {
            Node new_node = new Node(new_data);
            new_node.next = this.head;
            this.head = new_node;
            Console.WriteLine("inserted front" + new_node.data);
        }

        internal Node DeleteFirstNode()
        {
            if(this.head == null)
            {
                return null;
            }
            this.head = this.head.next;
            return this.head;
        }
    }
}
