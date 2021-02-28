using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Student
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private float cgpa;

        public float Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }
        Department department;
        public Department Department
        {
            get { return department; }
            set { department= value; }
            
        }


        public Student()
        {

        }
        public Student(string name, int id, float cgpa)
        {
            this.name = name;
            this.id = id;
            this.cgpa = cgpa;
        }



        public void ShowInfo()
        {
            Console.WriteLine("Name:" + name);
            Console.WriteLine("ID:" + id);
            Console.WriteLine("Cgpa:" + cgpa);
            Department.ShowInfo();
        }







    }
}
