using Day14_Assignment.Queue_uc3_uc4;
using Day14_Assignment.uc1_uc2_Stack;
using System;

namespace Day14_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            #region UC1 Creat Stack
            Console.WriteLine("-----UC1-----");
            uc1_uc2Stack stack = new uc1_uc2Stack();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Printstack();
            #endregion
            Console.WriteLine("\n----------------------------------------------------");


            #region UC2 peek and pop till empty
            Console.WriteLine("-----UC2-----");
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Printstack();
            stack.Peek();
            stack.Pop();
            stack.EmptyStack();
            #endregion
            Console.WriteLine("\n----------------------------------------------------");


            #region UC3 Enqueue- Creat queue
            Console.WriteLine("-----UC3-----");
            Queueuc3_uc4 queue = new Queueuc3_uc4();
            queue.enqueue(56);
            queue.enqueue(30);
            queue.enqueue(70);
            queue.PrintQueue();
            #endregion
            Console.WriteLine("\n----------------------------------------------------");

            #region UC4 Dequeue List
            Console.WriteLine("-----UC4-----");
            Console.WriteLine("enqued list:");
            queue.enqueue(56);
            queue.enqueue(30);
            queue.enqueue(70);
            queue.PrintQueue();
            Console.WriteLine("\n------------");
            queue.dequeue();
            queue.PrintQueue();
            queue.dequeue();
            queue.PrintQueue();
            queue.dequeue();
            queue.PrintQueue();
            #endregion

            Console.ReadKey();
        }
       
        
    }
}
