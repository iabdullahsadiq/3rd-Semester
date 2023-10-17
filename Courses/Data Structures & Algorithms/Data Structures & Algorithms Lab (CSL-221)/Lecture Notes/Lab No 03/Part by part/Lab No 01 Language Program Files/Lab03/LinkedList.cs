using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    public class LinkedList
    {
        public Node head;
        public void printList()
        {
            Node n = head;
            while (n != null)
            {
                Console.Write(n.data + " ");
                n = n.next;
            }
        }
        
        /*public void push(int new_data)
        {
            Node new_node = new Node(new_data);
            new_node.next = head;
            head = new_node;
        }*/
        /*public void insertAfter(Node prev_node, int new_data)
        {
            if (prev_node == null)
            {
                Console.WriteLine("The given previous" + " node cannot be null");
                return;
            }
            Node new_node = new Node(new_data);
            new_node.next = prev_node.next;
            prev_node.next = new_node;
        }*/
        public void append(int new_data)
        {
            Node new_node = new Node(new_data);
            if (head == null)
            {
                head = new Node(new_data);
                return;
            }
            new_node.next = null;
            Node last = head;
            while (last.next != null)
            last = last.next;
            last.next = new_node;
            return;
        }
        public void deleteNode(int key)
        {
            Node temp = head, prev = null;
            if (temp != null && temp.data == key)
            {
                head = temp.next;
                return;
            }
            while (temp != null && temp.data != key)
            {
                prev = temp;
                temp = temp.next;
            }
            if (temp == null)
                return;
            prev.next = temp.next;
        }
        
    }
}