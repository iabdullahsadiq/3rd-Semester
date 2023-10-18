using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class Program
    {
        static void Main(string[] args)
        {
            DLL dll = new DLL();

            // Insert 6. So linked list becomes 6->NULL
            dll.append(6);

            // Insert 7 at the beginning.
            // So linked list becomes 7->6->NULL
            dll.push(7);

            // Insert 1 at the beginning.
            // So linked list becomes 1->7->6->NULL
            dll.push(1);

            // Insert 4 at the end. So linked list
            // becomes 1->7->6->4->NULL
            dll.append(4);

            // Insert 8, after 7. So linked list
            // becomes 1->7->8->6->4->NULL
            dll.InsertAfter(dll.head.next, 8);

            Console.WriteLine("Created DLL is: ");
            dll.printlist(dll.head);
            dll.deleteNode(dll.head.next);

            Console.Write("\nList after Deleting middle node: ");
            dll.printlist(dll.head);


        }
    }
}
