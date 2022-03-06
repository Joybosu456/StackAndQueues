using System;
using System.Collections.Generic;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>(); 
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);
            queue.Enqueue(7);
            queue.Enqueue(8);

            foreach(int item in queue)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}