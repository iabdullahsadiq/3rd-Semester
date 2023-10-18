using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    public class DLL
    {
        Node head;
        public void printlist(Node node)
        {
            Node last = null;
            Console.WriteLine("Traversal in forward Direction");
            while (node != null)
            {
                Console.Write(node.data + " ");
                last = node;
                node = node.next;
            }
            Console.WriteLine();
            Console.WriteLine("Traversal in reverse direction");
            while (last != null)
            {
                Console.Write(last.data + " ");
                last = last.prev;
            }

        }
        public void push(int new_data)
        {
            /* 1. allocate node
            * 2. put in the data */
            Node new_Node = new Node(new_data);

            /* 3. Make next of new node as head and previous as NULL */
            new_Node.next = head;
            new_Node.prev = null;

            /* 4. change prev of head node to new node */
            if (head != null)
                head.prev = new_Node;

            /* 5. move the head to point to the new node */
            head = new_Node;
        }
        public void InsertAfter(Node prev_Node, int new_data)
        {

            /*1. check if the given prev_node is NULL */
            if (prev_Node == null)
            {
                Console.WriteLine("The given previous node cannot be NULL ");
                return;
            }

            /* 2. allocate node
            * 3. put in the data */
            Node new_node = new Node(new_data);
            new_node.next = prev_Node.next;

            /* 5. Make the next of prev_node as new_node */
            prev_Node.next = new_node;

            /* 6. Make prev_node as previous of new_node */
            new_node.prev = prev_Node;

            /* 7. Change previous of new_node's next node */
            if (new_node.next != null)
                new_node.next.prev = new_node;
        }
        void append(int new_data)
        {
            /* 1. allocate node
            * 2. put in the data */
            Node new_node = new Node(new_data);

            Node last = head; /* used in step 5*/

            /* 3. This new node is going
                to be the last node, so
            * make next of it as NULL*/
            new_node.next = null;

            /* 4. If the Linked List is empty,
            then make the new * node as head */
            if (head == null)
            {
                new_node.prev = null;
                head = new_node;
                return;
            }

        }
        while (last.next != null)
            last = last.next;
 
        /* 6. Change the next of last node */
        last.next = new_node;
 
        /* 7. Make last node as previous of new node */
        new_node.prev = last;
            void deleteNode(Node del)
        {

            // Base case
            if (head == null || del == null)
            {
                return;
            }

            // If node to be deleted is head node
            if (head == del)
            {
                head = del.next;
            }
        }
        if (del.next != null)
        {
            del.next.prev = del.prev;
        }
 
        // Change prev only if node to be deleted
        // is NOT the first node
        if (del.prev != null)
        {
            del.prev.next = del.next;
        }

// Finally, free the memory occupied by del
return;
    }
static void deleteNodeAtGivenPos(Node head, int n)
{
    /* if list in NULL or invalid position is given */
    if (head == null || n <= 0)
        return;

    Node current = head;
    int i;

    /*
        * traverse up to the node at position 'n' from the beginning
        */
    for (i = 1; current != null && i < n; i++)
    {
        current = current.next;
    }
    if (current == null)
        return;

    // delete the node pointed to by 'current'
    deleteNode(head, current);
}
Node head = null;

// Create the doubly linked list:
// 2<->2<->10<->8<->4<->2<->5<->2

head = push(head, 2);
head = push(head, 5);
head = push(head, 4);
head = push(head, 8);
head = push(head, 10);

Console.WriteLine("Doubly linked list before deletion:");
printList(head);

int n = 2;

// delete node at the given position 'n'
deleteNodeAtGivenPos(head, n);
Console.WriteLine("Doubly linked list after deletion:");
printList(head);



}
}