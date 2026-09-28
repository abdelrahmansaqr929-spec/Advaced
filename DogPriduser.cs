using System;
using System.Collections.Generic;
using System.Text;

namespace Abvanced
{
    internal class DogPriduser : IProduser<Dog>
    {
        public Dog Get()
        {
            return default(Dog);
        }
    }
}
