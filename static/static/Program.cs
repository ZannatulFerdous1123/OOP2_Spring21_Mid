using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @static
{
    class Program
    {static void Swap(  int x,int y)
        {
            int temp = x;
            x = y;
            y = temp;
            Console.WriteLine("x={0} and y={1}", x, y);
            Console.WriteLine(" ");
        }
        static void SwapRef(ref int i, ref int j)
        {
            int tempp = i;
            i = j;
            j = tempp;
        }
            static void Outexample(out int a)
        { a = 5;
        }
        static void Main(string[] args)
        {
            int x = 10, y=12;
            Console.WriteLine("pass by value");
            Console.WriteLine("x={0} and y={1}", x, y);
            Swap( x, y);

            int i= 10, j = 12;
            Console.WriteLine("pass by reference");
            Console.WriteLine("i={0} and j={1}", i, j);
            SwapRef(ref i,ref j);
            Console.WriteLine("i={0} and j={1}", i, j);
            Console.WriteLine(" ");

            int a ;
            //Console.WriteLine(a);
            Outexample(out a);
            Console.WriteLine("Out Example");
            Console.WriteLine(a);

        }
    }
}
