using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChaining
{
    class B
    {
        public B()
        {
            Console.WriteLine("default constructor: B");
        }

        public B(int num):this()
        {
            Console.WriteLine("with 1 parameter: B");
        }
    }
}
