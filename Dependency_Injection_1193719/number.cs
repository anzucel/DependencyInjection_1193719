using System;
using System.Collections.Generic;

namespace Dependency_Injection_1193719
{
    public interface ITransient
    {

    }

    public class number : ITransient, ISingleton
    {
        public readonly int value;

        public number()
        {
            value = new Random().Next(1000);
        }

    }
}
