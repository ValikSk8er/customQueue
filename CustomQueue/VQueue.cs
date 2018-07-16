using System;
using System.Collections.Generic;

namespace CustomQueue
{
    /// <summary>
    /// VQueue - FIFO
    /// </summary>
    public class VQueue<T>
    {
        private static List<T> QueueCollection = new List<T>();

        /// <summary>
        /// ExtractFirst is a method to extracts and return element from queue
        /// </summary>
        /// Returns first queue element
        public T ExtractFirst()
        {
            var extactedElement = QueueCollection[0];
            QueueCollection.RemoveAt(0);
            return extactedElement;
        }

        /// <summary>
        /// Add is a method to add element to the end of queue
        /// </summary>
        public void Add(T element)
        {
            QueueCollection.Add(element);
        }

        /// <summary>
        /// GetFirst is a method to return first element from queue
        /// </summary>
        /// Returns first queue element
        public T GetFirst()
        {
            return QueueCollection[0];
        }

        /// <summary>
        /// ShowQueue is a method to display all elements in queue
        /// </summary>
        public void ShowQueue()
        {
            foreach (var element in QueueCollection)
            {
                Console.WriteLine(element.ToString());
            }
        }
    }
}
