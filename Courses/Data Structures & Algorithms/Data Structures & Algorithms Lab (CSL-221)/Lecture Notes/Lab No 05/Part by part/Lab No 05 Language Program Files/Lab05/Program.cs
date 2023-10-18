using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    class Program
    {
            internal class Stack
            {
                static readonly int MAX = 1000;
                int top;
                int[] stack = new int[MAX];
                bool isEmpty()
                {
                    return (top < 0);
                }
                public Stack()
                {
                    top = -1;
                }
                internal bool Push(int data)
                {
                    if (top >= MAX)
                    {
                        Console.WriteLine("Stack Overflow");
                        return false;
                    }
                    else
                    {
                        stack[++top] = data;
                        return true;
                    }
                }
                internal int pop()
                {
                    if (top < 0)
                    {
                        Console.WriteLine("Stack Overflow");
                        return 0;
                    }
                    else
                    {
                        int value = stack[top--];
                        return value;
                    }
                }
                internal void Peek()
                {
                    if (top < 0)
                    {
                        Console.WriteLine("Stack Overflow");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("The top most value is: {0}", stack[top]);
                    }
                }
                internal void printStack()
                {
                    if (top < 0)
                {
                        Console.WriteLine("Stack Overflow");
                        return;
                }
                    else
                {
                        Console.WriteLine("Items in the stack are: ");
                        for (int i = top; i >= 0; i--)
                    {
                            Console.WriteLine(stack[i]);
                    }
                }
            }
        }
            public static void Main(string[] args)
        {
                Stack myStack = new Stack();
                myStack.Push(10);
                myStack.Push(20);
                myStack.Push(30);
                myStack.Push(40);
                myStack.printStack();
                myStack.Peek();

        }
    }
}