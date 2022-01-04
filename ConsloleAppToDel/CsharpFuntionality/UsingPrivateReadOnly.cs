using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsloleAppCalculator
{
    public class UsingPrivateReadOnly
    {
        private readonly int _count;

        public UsingPrivateReadOnly(int count)
        {
            this._count = count;
        }

        public int Count => _count;

        public void printer()
        {
            Console.WriteLine(Count);

        }
    }
}
