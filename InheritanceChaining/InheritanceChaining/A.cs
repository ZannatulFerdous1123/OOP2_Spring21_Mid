using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChaining
{
    class A:B
    {
        public A():base(10)
        {
            Console.WriteLine("Default Constructor called : A");
        }

        public A(int num):this()
        {
            Console.WriteLine("Constructor with 1 parameter : A ");
        }
    }
}
