using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Triangle
    {
        private int x;
        private int y;
        private int z;

        private Triangle()
        {

        }
        private Triangle(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        private void ShowInfo()
        {
            if (x == y && x == z)
            {
                Console.WriteLine("Triangle is equilateral");
            }
            if (x == y || x == z)
            {
                Console.WriteLine("Triangle is isosceles");
            }


            else
            {
                Console.WriteLine("Triangle is scalene");
            }
        }
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(4, 2, 4);

            triangle.ShowInfo();
        }
    }
}