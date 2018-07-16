using System;

namespace CustomQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            VQueue<int> myQueue = new VQueue<int>();

            myQueue.Add(1);
            myQueue.Add(2);
            myQueue.Add(3);
            myQueue.Add(4);
            myQueue.Add(5);
            myQueue.Add(6);
            myQueue.ShowQueue();

            myQueue.ExtractFirst();
            Console.WriteLine("first element was extracted");
            myQueue.ShowQueue();

            myQueue.ExtractFirst();
            Console.WriteLine("first element was extracted");
            myQueue.ShowQueue();

            Console.WriteLine($"Get first - {myQueue.GetFirst()}");
            myQueue.ShowQueue();

            Console.ReadLine();
        }
    }
}
