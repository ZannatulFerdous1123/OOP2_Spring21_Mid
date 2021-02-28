using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExtended
{
    class Program
    {
        static void PrintArray(int[] arr)
        {
            foreach (int a in arr)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine(arr.Length);
        }

        static void PrintTwoD(int[,] arr)
        {
            foreach(int a in arr)
            { 
             Console.WriteLine(a);
            }

            int r = arr.GetLength(0);
            int c = arr.GetLength(1);
            Console.WriteLine(r);
            Console.WriteLine(c);
            /*for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }*/
        }
        static void PrintJaggedArray(int[][] arr)
        {
            int r = arr.Length;
            Console.WriteLine("Jagged Array length: {0}", r);
            foreach (int[] innerArr in arr)
            {
                foreach (int num in innerArr)
                {
                    Console.WriteLine(num);
                }
                Console.WriteLine("Array length: {0}", innerArr.Length);
                Console.WriteLine();
            }

            
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int[,] arrTwoD = { { 1, 2, 3 }, { 4, 5, 6 } };
            int[][] jagged = new int[][] { new int[] { 1, 2, 3, 4 }, new int[] { 10, 11, 12 }, new int[] { 7, 8, 9 } };
            PrintJaggedArray(jagged);
            //PrintTwoD(arrTwoD);
            //PrintArray(arr);
            //Console.ReadKey();
        }
    }
}
