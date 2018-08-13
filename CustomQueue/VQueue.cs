using System;

namespace CustomQueue
{
    /// <summary>
    /// VQueue - Valik's queue (FIFO)
    /// </summary>
    public class VQueue
    {
        private static object[] _queue;
        private static int _size = 4;
        //first element in queue
        private static int _head;
        //last element in queue
        private static int _tail;

        public VQueue()
        {
            _queue = new object[_size];
        }

        /// <summary>
        /// ExtractFirst is a method to extracts and return element from queue
        /// </summary>
        /// Returns first queue element
        public object ExtractFirst()
        {
            var extactedElement = _queue[_head];
            _queue[_head] = null;

            _head = _head + 1 < _size ? _head + 1 : 0;

            Console.WriteLine($"First element '{extactedElement}' was extracted");
            PrintSepareteLine();
            return extactedElement;
        }

        /// <summary>
        /// Add is a method to add element to the end of queue
        /// </summary>
        public void Add(object element)
        {
            if (_queue[_head] == null)
            {
                _queue[_head] = element;
            }
            else
            {
                int freeIndex = _tail + 1;
                if (freeIndex < _size && _queue[freeIndex] != null)
                {
                    CreateBiggestQueue();
                }

                if (freeIndex < _size)
                {
                    _queue[++_tail] = element;
                }
                else if (freeIndex == _size && _head == 0)
                {
                    CreateBiggestQueue();
                    _queue[++_tail] = element;
                }
                else
                {
                    _tail = 0;
                    _queue[_tail] = element;
                }

            }
            Console.WriteLine($"Element: '{element}' was added to queue");
            PrintSepareteLine();
        }

        /// <summary>
        /// GetFirst is a method to return first element from queue
        /// </summary>
        /// Returns first element in queue
        public object GetFirst()
        {
            Console.WriteLine($"First element in queue is '{_queue[_head]}'");
            PrintSepareteLine();
            return _queue[_head];
        }

        /// <summary>
        /// ShowQueue is a method to display all elements in queue
        /// </summary>
        public void ShowQueue()
        {
            Console.WriteLine("ShowQueue:");
            int iterationCounter = 0;

            for (int i = _head; iterationCounter < _queue.Length; i++)
            {
                if (i == _queue.Length)
                {
                    i = 0;
                }
                iterationCounter++;

                if (_queue[i] != null)
                {
                    Console.WriteLine($"Element: '{_queue[i]}' wiht index '{i}'");
                }
            }

            PrintSepareteLine();
        }

        private void CreateBiggestQueue()
        {
            int newSize = _size + 2;
            object[] biggestQueue = new object[newSize];

            int j = 0;
            for (int i = _head; i <= _queue.Length; i++)
            {

                if (i == _queue.Length)
                {
                    i = 0;
                }

                biggestQueue[j] = _queue[i];
                j++;

                if (j == _queue.Length)
                {
                    break;
                }
            }

            _queue = biggestQueue;
            _head = 0;
            _tail = _size - 1;
            _size = newSize;
        }

        private void PrintSepareteLine()
        {
            int charsNumber = 35;
            Console.WriteLine(new string('-', charsNumber));
        }
    }
}
