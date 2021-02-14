using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Programs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("main array ");
            int[] arr = new int[] { 2, 4 };
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i] + " ");
            Console.WriteLine( "copy array ");
            int[] arr2 = new int[arr.Length];

            for (int i=0;i<arr.Length; i++)
            {
                arr2[i] = arr[i];
                Console.WriteLine(arr2[i] + " ");
            }
               
         
            




        }
    }
}
