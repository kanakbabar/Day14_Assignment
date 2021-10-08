using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_Assignment.Queue_uc3_uc4
{
    class Queueuc3_uc4
    {
        Queue_Node head, tail;

        public void Queue()
        {
            this.head = this.tail = null;
        }

        //UC3 to add a queue
        public void enqueue(int key)
        {


            Queue_Node temp = new Queue_Node(key);


            if (this.tail == null)
            {
                this.head = this.tail = temp;
                return;
            }


            this.tail.next = temp;
            this.tail = temp;

        }

        //UC4 to dequeue

        public void dequeue()
        {

            if (this.head == null)
                return;


            Queue_Node temp = this.head;
            this.head = this.head.next;


            if (this.head == null)
                this.tail = null;
            Console.WriteLine("Head is removed");
        }

        internal void PrintQueue()
        {
            Queue_Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }

            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }


        }
    }
}
