using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Course
    {
        private String Name;
        private String Code;
        private int Credit;

        public Course()
        {

        }
        public Course(String Name, String Code,int Credit)
        {
            this.Name = Name;
            this.Code = Code;
            this.Credit = Credit;
        }
        public void ShowCourseInfo()
        {
            Console.WriteLine("Course name:" + Name);
            Console.WriteLine("Course Code:" + Code);
            Console.WriteLine("Course Credit:" + Credit);

        }

            
        static void Main(string[] args)
        {
            Course C = new Course("OBJECT ORIENTED PROGRAMMING 2","000754",3);
            C.ShowCourseInfo();
        }
    }
}
