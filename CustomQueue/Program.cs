using System;

namespace CustomQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            VQueue myQueue = new VQueue();

            myQueue.Add(1);
            myQueue.Add(2);
            myQueue.Add(3);
            myQueue.Add(4);
            myQueue.ShowQueue();
            myQueue.ExtractFirst();
            myQueue.ShowQueue();
            myQueue.ExtractFirst();
            myQueue.ShowQueue();
            myQueue.Add(5);
            myQueue.ShowQueue();
            myQueue.Add(6);
            myQueue.ShowQueue();
            myQueue.Add(7);
            myQueue.ShowQueue();
            myQueue.Add(8);
            myQueue.Add(9);
            myQueue.ShowQueue();
            myQueue.Add(10);
            myQueue.ShowQueue();
            myQueue.Add(11);
            myQueue.Add(12);
            myQueue.Add(13);
            myQueue.ExtractFirst();
            myQueue.ShowQueue();
            myQueue.Add(14);
            myQueue.ExtractFirst();
            myQueue.ExtractFirst();
            myQueue.ExtractFirst();
            myQueue.ExtractFirst();
            myQueue.ShowQueue();
            Console.ReadLine();
        }
    }
}
