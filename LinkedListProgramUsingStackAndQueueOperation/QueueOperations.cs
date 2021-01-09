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
        public void Enqueue(int value)
        {
            Node node = new Node(value);
            if (this.rear == null)
            {
                this.front = this.rear = node;
            }
            this.rear.next = node;
            this.rear = node;
        }
        public void DisplayQueue()
        {
            Node temp = front;
            while(temp!=null)
            {
                Console.Write("\n"+temp.data + " ");
                temp = temp.next;
                
            }
        }
    }
}
