using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace CustomQueue
{
    /// <summary>
    /// VQueue - FIFO
    /// </summary>
    public class VQueue<T>
    {
        private static ObservableCollection<T> QueueCollection;

        public VQueue()
        {
            QueueCollection = new ObservableCollection<T>();
            QueueCollection.CollectionChanged += QueueCollection_Changed;
        }

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
        public void ShowQueue(Action<T> displyAction)
        {
            foreach (var element in QueueCollection)
            {
                displyAction(element);
            }
        }

        private static void QueueCollection_Changed(object sender, NotifyCollectionChangedEventArgs eventArgs)
        {
            switch (eventArgs.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    var addedElement = eventArgs.NewItems[0];
                    Console.WriteLine($"Element '{addedElement}' was added to the end of queue");
                    break;

                case NotifyCollectionChangedAction.Remove:
                    var extractedElement = eventArgs.OldItems[0];
                    Console.WriteLine($"Element '{extractedElement}' was extracted from queue");
                    break;
            }
        }
    }
}
