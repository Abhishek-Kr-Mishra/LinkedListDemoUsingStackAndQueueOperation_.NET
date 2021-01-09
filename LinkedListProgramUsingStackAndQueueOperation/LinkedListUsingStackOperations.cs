using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProgramUsingStackAndQueueOperation
{
    class LinkedListUsingStackOperations
    {
        private Node top;
        internal void Push(int value)
        {
            Node node = new Node(value);
            if(this.top==null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} pushed to stack", value);
        }
        internal void Display()
        {
            Node temp = this.top;
            if (temp == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
            }
        }
        internal void Peek()
        {
            if(this.top==null)
            {
                Console.WriteLine("Can't get any Value.......Stack is Empty");
                return;
            }
            Console.WriteLine("\n{0} is at the top of stack ", this.top.data);
        }
        internal void Pop()
        {
            if(this.top==null)
            {
                Console.WriteLine("Stack is Empty..... Can't Pop Any Value");
                return;
            }
            Console.WriteLine("Poped Value From Stack is " + this.top.data);
            this.top = this.top.next;
        }
        internal void IsEmpty()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is Already Empty");
            }
            else
            {
                while (this.top != null)
                {
                    Peek();
                    Pop();
                }
            }
        }
    }
}
