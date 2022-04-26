using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2
{
    public class ComputerDirector
    {
        public T Construct<T>(IComputerBuilder<T> builder) where T : Computer
        {
            return builder.Build();
        }
    }
}
