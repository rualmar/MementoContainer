﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoContainer.Adapters
{
    /// <summary>
    /// Wraps a <see cref="Queue{T}"/> instance, allowing the memento container to read/restore its state.
    /// </summary>
    /// <typeparam name="T">The type of the elements in the queue.</typeparam>
    public class QueueAdapter<T> : ICollectionAdapter<Queue<T>, T>
    {
        /// <summary>
        /// Gets or sets the collection being adapted.
        /// </summary>
        public Queue<T> Collection { get; set; }

        /// <summary>
        /// Gets the number of elements contained in the <see cref="Queue{T}"/>.
        /// </summary>
        public int Count
        {
            get { return Collection.Count; }
        }

        /// <summary>
        /// Removes all items from the <see cref="Queue{T}"/>.
        /// </summary>
        public void Clear()
        {
            Collection.Clear();
        }

        /// <summary>
        /// Adds a set of items to the <see cref="Queue{T}"/>.
        /// </summary>
        /// <param name="items">The items that should be added to the <see cref="Queue{T}"/>.</param>
        public void AddRange(IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                Collection.Enqueue(item);
            }
        }

        /// <summary>
        /// Copies the elements of the collection to an System.Array, starting at a particular System.Array index.
        /// </summary>
        /// <param name="array">The one-dimensional System.Array that is the destination of the elements copied from <see cref="Queue{T}"/>.</param>
        /// <param name="arrayIndex">The zero-based index in array at which copying begins.</param>
        public void CopyTo(T[] array, int arrayIndex)
        {
            Collection.CopyTo(array, arrayIndex);
        }
    }
}
