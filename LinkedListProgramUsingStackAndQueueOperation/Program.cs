using System;

namespace LinkedListProgramUsingStackAndQueueOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListUsingStackOperations linkedListProgramUsingStack = new LinkedListUsingStackOperations();

            linkedListProgramUsingStack.Push(70);
            linkedListProgramUsingStack.Push(30);
            linkedListProgramUsingStack.Push(56);
            linkedListProgramUsingStack.Display();

            linkedListProgramUsingStack.Peek();

            linkedListProgramUsingStack.Pop();
            linkedListProgramUsingStack.Display();

            linkedListProgramUsingStack.IsEmpty();
            linkedListProgramUsingStack.Display();
        }
        
    }
}
