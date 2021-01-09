using System;

namespace LinkedListProgramUsingStackAndQueueOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListUsingStackOperations linkedListProgramUsingStack = new LinkedListUsingStackOperations();
            QueueOperations queueOperations = new QueueOperations();

            linkedListProgramUsingStack.Push(70);
            linkedListProgramUsingStack.Push(30);
            linkedListProgramUsingStack.Push(56);
            linkedListProgramUsingStack.Display();

            linkedListProgramUsingStack.Peek();

            linkedListProgramUsingStack.Pop();
            linkedListProgramUsingStack.Display();

            linkedListProgramUsingStack.IsEmpty();
            linkedListProgramUsingStack.Display();

            queueOperations.Enqueue(56);
            queueOperations.Enqueue(30);
            queueOperations.Enqueue(70);
            Console.WriteLine("Queue Value");
            queueOperations.DisplayQueue();
        }
        
    }
}
