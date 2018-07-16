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
            myQueue.ShowQueue(x => Console.WriteLine(x));

            myQueue.ExtractFirst();
            myQueue.ShowQueue(x => Console.WriteLine(x));

            myQueue.ExtractFirst();
            myQueue.ShowQueue(x => Console.WriteLine(x));

            myQueue.ExtractFirst();
            myQueue.ShowQueue(x => Console.WriteLine(x));

            Console.WriteLine($"Get first - {myQueue.GetFirst()}");
            myQueue.ShowQueue(x => Console.WriteLine(x));

            Console.ReadLine();
        }
    }
}
