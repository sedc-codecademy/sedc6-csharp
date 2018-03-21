using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class MyList<T>
    {
        private List<T> _items = new List<T>();
        public int Count
        {
            get
            {
                return _items.Count;
            }
        }
        public void Add(T item)
        {
            _items.Add(item);
        }
        public void RemoveAtIndex(T item)
        {
            _items.Remove(item);
        }
        public T Get(int index)
        {
            return _items[index];
        }
    }
}
