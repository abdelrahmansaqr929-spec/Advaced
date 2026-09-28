
using System;
using System.Collections.Generic;
using System.Text;

namespace Abvanced
{
    internal interface I<in T>
    {
        void proces(T item);
    }
}
