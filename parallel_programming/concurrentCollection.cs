using System;
using System.Collections.Generic;
using System.Text;

namespace parallel_programming
{
    /// <summary>
    /// introduce in  .NET 4.0 (System.Collections.Concurrent.)
    //ConcurrentStack<T> - This is thread-safe last-in-first-out collection.
    //ConcurrentQueue<T> - This is thread-safe first-in-first-out collection.
    //BlockingCollection<T> - This collection is thread-safe for adding and removing data. You can set maximum upper limit to add items in this collection. Removing an item from     the collection can be blocked until item becomes available.
    //ConcurrentBag<T> -ConcurrentBag is thread-safe collection. This collection is like just at bag or heap of objects. It has not ordering and it allow duplicate items.
    //ConcurrentDictionary<TKey, T> -Concurrent dictionary is thread-safe collection. It is used to store key-value pair in multi-threaded environment.
    /// </summary>
    class ConcurrentCollection
    {
    }
}
