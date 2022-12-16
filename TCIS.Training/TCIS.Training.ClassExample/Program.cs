using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCIS.Training.ClassExample.Entities;

namespace TCIS.Training.ClassExample
{
    class Program
    {
        static List<Teacher> Teachers { get; set; }
        static List<Class> Classes { get; set; }
        static List<Subject> Subjects { get; set; }
        static List<Student> Students { get; set; }
        static List<Examation> Examations { get; set; }

        static void DummyData()
        {
            var subjects = new List<string> { "ANH", "TOAN", "HOA", "VAN", "SU", "DIA", "GDCD" };
            var classes = new List<string> { "12A1", "12A2", "12A3", "12A4", "12A5", "12A6", "12A7" };
            var teacherLastNames = new List<string> { "NGUYEN", "TRAN", "LE", "HOANG", "LY" };
            var teacherFirstNames = new List<string> { "DUNG", "HIEU", "TIEN", "NHAN", "QUAN" };

            Teachers = new List<Teacher>();
            Classes = new List<Class>();
            Subjects = new List<Subject>();
            Students = new List<Student>();
            Examations = new List<Examation>();

            var random = new Random();

            for (int i = 0; i < teacherLastNames.Count * teacherLastNames.Count; i++)
            {
                var newName = $"{teacherLastNames[random.Next(1, teacherLastNames.Count)]} {teacherFirstNames[random.Next(1, teacherFirstNames.Count)]}";
                Teachers.Add(new Teacher(i + 1, newName));
            }

            for (int i = 0; i < subjects.Count; i++)
            {
                Subjects.Add(new Subject(i + 1, subjects[random.Next(1, subjects.Count)]));
            }

            for (int i = 0; i < classes.Count; i++)
            {
                Classes.Add(new Class(i + 1, classes[random.Next(1, classes.Count)], Teachers[random.Next(1, Teachers.Count)]));
            }
        }

        static void Main(string[] args)
        {
            DummyData();

            foreach (var s in Teachers)
            {
                Console.WriteLine(s.ToString());
            }

            Console.WriteLine("--------------------");

            foreach (var s in Subjects)
            {
                Console.WriteLine(s.ToString());
            }

            Console.WriteLine("--------------------");

            foreach (var s in Classes)
            {
                Console.WriteLine(s.ToString());
            }


            Console.ReadKey();
        }
    }
}
