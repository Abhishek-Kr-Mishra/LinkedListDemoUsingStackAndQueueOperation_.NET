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

            queueOperations.EnQueue(56);
            queueOperations.EnQueue(30);
            queueOperations.EnQueue(70);
            Console.WriteLine("Whole Queue Value");
            queueOperations.DisplayQueue();

            queueOperations.DeQueue();
            queueOperations.DisplayQueue();
        }
        
    }
}
