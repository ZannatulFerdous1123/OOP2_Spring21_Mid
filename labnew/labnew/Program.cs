using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labnew
{
    class Student
    {
        
        private String Name;
        private String Id;
        private String Department;
        private float Cgpa;
        public Student(String Name, String Id, String Department, float Cgpa)
        {
            this.Name = Name;
            this.Id = Id;
            this.Department = Department;
            this.Cgpa = Cgpa;
        }

        public Student()
        {
        }


        public void ShowInfo()
        {
            Console.WriteLine("Student name:" + Name);
            Console.WriteLine("Student id:" + Id);
            Console.WriteLine("Student Department:" + Department);
            Console.WriteLine("Student cgpa:" + Cgpa);
        }


        static void Main(string[] args)
        {


            Student S1 = new Student("jannat","18-38302-2","CSE", 3.75f );
            S1.ShowInfo();

        }
    }
}


