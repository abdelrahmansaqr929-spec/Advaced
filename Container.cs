using System;
using System.Collections.Generic;
using System.Text;

namespace Abvanced
{
    internal class Container<T>: IReposatory<T>
    {
        private T Value;
       public void Add(T item)
        {
            Value = item;
        }
        public T Get()
        {
            return Value; 
        }
    }
}
