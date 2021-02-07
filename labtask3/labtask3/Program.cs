using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labtask3
{
    class Program
    {
        static void Main(string[] args)
        {
            int physics = 88;
            int chemistry = 86;
            int biology = 82;
            int math = 80;
            int computer = 85;
            int totalMark = 500;

            int total = physics + chemistry + biology + math + computer;
            double Percentage = (total * 100) / totalMark;
            Console.WriteLine("percentage:" + Percentage);

            if (Percentage >= 90)
            {
                Console.WriteLine("The grade is:A+");

            }
            if (Percentage < 90 && Percentage >= 85)
            {
                Console.WriteLine("The grade is:A");
            }
            if (Percentage < 85 && Percentage >= 80)
            {

                Console.WriteLine("The grade is:B+");
            }
            if (Percentage < 80 && Percentage >= 75)
            {
                Console.WriteLine("The grade is:B");
            }
            if (Percentage < 75 && Percentage >= 50)
            {
                Console.WriteLine("The grade is:C+");
            }
            if (Percentage < 50)
            {
                Console.WriteLine(" The grade is:F");
            }
            }
    }
}
