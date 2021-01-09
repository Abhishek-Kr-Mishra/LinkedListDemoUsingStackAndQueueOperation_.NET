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
    }
}
