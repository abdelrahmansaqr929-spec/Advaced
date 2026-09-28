using System;
using System.Collections.Generic;
using System.Text;

namespace Abvanced
{
    internal class Container<T>: IReposatory<T>
    { 
       public static int count =0;
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
