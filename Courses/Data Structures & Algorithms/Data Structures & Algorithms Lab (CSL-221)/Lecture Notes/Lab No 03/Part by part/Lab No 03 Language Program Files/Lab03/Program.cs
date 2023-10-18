using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList llist = new LinkedList();

            llist.head = new Node(1);
            Node second = new Node(2);
            Node third = new Node(3);
            llist.head.next = second;
            second.next = third;
            llist.printList();
            GFG list = new GFG();
            llist.append(6);
            //llist.push(7);
            //llist.push(1);
            llist.append(4);
            //llist.insertAfter(llist.head.next, 8);
            Console.Write("Created Linked list is: ");
            llist.printList();
            //llist.deleteNode(1);
        }
    }
}