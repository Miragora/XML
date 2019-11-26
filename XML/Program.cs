using System;
using System.Xml.Serialization;
using System.IO;

namespace XML
{
    class Program
    {
        static void Main()
        {
            var Group = new StudentGroup();
            Group.Name = "BirthdayOfKaterina";
            for (int i = 1; i <= 10; i++)
            {
                var student = new Student();
                student.Name = "Студент" + i;
                student.SecondName = "Фамилия " + i;
                student.Age = 18 + i;
                Group.Students.Add(student);
            }
            var serializer = new XmlSerializer(typeof(StudentGroup));    
            using (var file = File.Create("students.xml"))
            {
                serializer.Serialize(file, Group);
            }
        


            Console.ReadLine();
        }
    }
}
