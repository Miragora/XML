using System;
using System.Collections.Generic;
using System.Text;

namespace XML
{
    public class StudentGroup
    {
        //свойства - название
        public string Name { get; set;}
        public List<Student> Students { get; set; } = new List<Student>();

    }

    public class Student
    {
        public string Name { get; set; }
        public string SecondName { get; set; }
        public int Age { get; set; }
        public List<int> Ratings { get; set; } = new List<int>();
    }
}
