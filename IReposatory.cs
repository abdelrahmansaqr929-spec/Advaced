using System;
using System.Collections.Generic;
using System.Text;

namespace Abvanced
{
    internal interface IReposatory<T>
    {
        void Add( T item);
         T Get();
    }
}
