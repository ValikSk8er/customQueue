using System;

namespace CustomQueue
{
    /// <summary>
    /// VQueue - FIFO
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

            if (_head + 1 < _size)
            {
                _head++;
            }
            else if(_head + 1 == _size)
            {
                _head = 0;
            }

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
                if (_tail + 1 < _size && _queue[_tail + 1] != null)
                {
                    CreateBiggestQueue();
                }

                if (_tail + 1 < _size)
                {
                    _tail++;
                    _queue[_tail] = element;
                }
                else if (_tail + 1 == _size && _head == 0)
                {
                    CreateBiggestQueue();
                    _tail++;
                    _queue[_tail] = element;
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
        /// Returns first queue element
        public object GetFirst()
        {
            Console.WriteLine($"First element '{_queue[_head]}' was get");
            PrintSepareteLine();
            return _queue[_head];
        }

        /// <summary>
        /// ShowQueue is a method to display all elements in queue
        /// </summary>
        public void ShowQueue()
        {
            Console.WriteLine("ShowQueue:");

            for (int i = 0; i < _size; i++)
            {
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
            Console.WriteLine(new string('-', 35));
        }
    }
}
