using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresIntro
{
    class Student
    {
        public int Id { get; set; }
        public float GPA { get; set; }

        public Student(int Id,  float GPA)
        {
            this.Id = Id;
            this.GPA = GPA;
        }

        

    }
}
