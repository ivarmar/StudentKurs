using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentKurs
{
    internal class Student
    {
        public Student(string name, int age, string course, string chosenCourse)
        {
            Name = name;
            Age = age;
            Course = course;
            ChosenCourse = chosenCourse;
        }

        public string Name { get; set; } 
        public int Age {  get; set; }
        public string Course { get; set; }

        public string ChosenCourse { get; set; }

    }
}
