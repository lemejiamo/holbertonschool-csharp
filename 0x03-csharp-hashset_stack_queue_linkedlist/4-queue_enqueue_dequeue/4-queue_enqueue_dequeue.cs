using System;
using System.Collections.Generic;

class MyQueue
{
	public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
	{
        int len_queue = aQueue.Count;
        string status = "False";
        string line = "";
        Console.WriteLine("{0}", line ="Number of items:"+len_queue.ToString("d"));

        if (len_queue > 0)
            Console.WriteLine("First item: {0}", aQueue.Peek());
        else
            Console.WriteLine("Queue is empty");

        if (aQueue.Contains(search))
        {
            status = "True";
            Console.WriteLine($"Queue contains {search}: {status}");
            while(aQueue.Dequeue() != search) ;
        }
        else
            Console.WriteLine($"Queue contains {search}: {status}");

        aQueue.Enqueue(newItem);

        return aQueue;
	}
}
