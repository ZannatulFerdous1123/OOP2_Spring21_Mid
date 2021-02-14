using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 3, 7,7,4,3 };
            int count = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[0] == arr[i])
                {
                    count++;
                }


            }
            for (int i = 2; i < arr.Length; i++)
            {
                if (arr[1] == arr[i])
                {
                    count++;
                }


            }
            for (int i = 3; i < arr.Length; i++)
            {
                if (arr[2] == arr[i])
                {
                    count++;
                }


            }
            for (int i = 4; i < arr.Length; i++)
            {
                if (arr[3] == arr[i])
                {
                    count++;
                }


            }
            for (int i = 5; i < arr.Length; i++)
            {
                if (arr[4] == arr[i])
                {
                    count++;
                }


            }

            Console.WriteLine("Total number of duplicate number : " + count);
        }
    }
}
