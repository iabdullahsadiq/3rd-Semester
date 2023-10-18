using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    public class Node
    {
        public int data;
        public Node prev;
        public Node next;
        Node(int d)
        {
            data = d;
        }
    }
}