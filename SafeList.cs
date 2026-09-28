using System;
using System.Collections.Generic;
using System.Text;

namespace Abvanced
{
    internal class SafeList<T>
    {
        public List<T> list = new List<T>();
        public void Add (T item)
        {
            list.Add(item);
        }
        public T Get (int index)
        {
            if (index > 0 && index < list.Count)
                return list[index];
            return default(T);
        } 
    }
}
