using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChaining
{
    class B
    {
        public B() : this(3)
        {
            Console.WriteLine("default constructor: B");
        }

        public B(int num)
        {
            Console.WriteLine("with 1 parameter: B");
        }
    }
}
