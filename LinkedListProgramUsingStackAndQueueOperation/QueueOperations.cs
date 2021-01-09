using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProgramUsingStackAndQueueOperation
{
    class QueueOperations
    {
        Node front, rear;
        public QueueOperations()
        {
            this.front = null; 
            this.rear = null;
        }
        public void EnQueue(int value)
        {
            Node node = new Node(value);
            if (this.rear == null)
            {
                this.front = this.rear = node;
            }
            this.rear.next = node;
            this.rear = node;
        }
        public void DeQueue()
        {
            if (front == null)
            {
                return;
            }
            Console.WriteLine("\nRemoved Value From Queue is " + front.data);
            front = front.next;
            if(front==null)
            {
                rear = null;
            }
        }
        public void DisplayQueue()
        {
            Node temp = front;
            if(front==null)
            {
                Console.WriteLine("Empty Queue");
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
