using System;
using System.Collections.Generic;
using System.Text;

namespace Abvanced
{
    internal interface IProduser<out T>
    {
        T Get();
    }
}
