using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Program
    {
        static void Main(string[] args)
        {
            Department d1 = new Department("computer science", "CS");
            Department d2 = new Department("Electrical engineering", "EEE");
            Student s1 = new Student("jannat", 111, 3.75f);
            Student s2 = new Student("momo", 112, 3.50f);
            Student s3 = new Student("fahmi", 113, 3.92f);
            d1.AddStudent(s1, s2, s3);
            s1.Department.ShowInfo();

            d1.AllStudents();

            Console.WriteLine("_____________________");
            d2.AddStudent(s1, s2, s3);
            s2.Department.ShowInfo();
            d2.AllStudents();
            Console.WriteLine("_____________________");
            s1.Department = d2;
            s1.ShowInfo();
        }
    }
}
