using System;
using System.Collections.Generic;
using System.Text;

namespace Abvanced
{
    internal class pair<T,U>
    {
        public T key;
        public U value;
        public pair (T key , U value)
        {
            key = key;
            value = value;
        }
    }
}
