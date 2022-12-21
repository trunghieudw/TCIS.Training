using System;
using System.Collections.Generic;
using System.Linq;
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
        static List<StudentClassificationCriteria> StudentClassificationCriterias { get; set; }
        static List<TeacherSalary> TeacherSalarys { get; set; }
        static List<SalaryClassification> SalaryClassifications { get; set; }

        static void DummyData()
        {
            var mandatorySubjects = new List<string> { "TOAN", "VAN", "ANH" };
            var classes = new List<string> { "12A1", "12A2", "12A3", "12A4", "12A5", "12A6", "12A7" };
            var teacherLastNames = new List<string> { "NGUYEN", "TRAN", "LE", "HOANG", "LY" };
            var teacherFirstNames = new List<string> { "DUNG", "HIEU", "TIEN", "NHAN", "QUAN" };
            var studentLastNames = new List<string> { "NGUYEN", "TRAN", "LE", "HOANG", "LY", "DINH" };
            var studentFirstNames = new List<string> { "HIEU", "SON", "NAM", "DUNG", "TIEN", "QUI", "KHAI", "PHI" };
            var studentMiddleNames = new List<string> { "VAN", "THANH", "TRUNG", "HOAI", "HOANG" };
            var classification = new List<string> { "GIOI", "KHA", "TRUNG BINH" };
            //var examationsScore = new List<decimal> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Teachers = new List<Teacher>();
            Classes = new List<Class>();
            Subjects = new List<Subject>();
            Students = new List<Student>();
            Examations = new List<Examation>();
            StudentClassificationCriterias= new List<StudentClassificationCriteria>();
            TeacherSalarys = new List<TeacherSalary>();
            SalaryClassifications = new List<SalaryClassification>();


            var random = new Random();

            for (int i = 0; i < teacherLastNames.Count * teacherLastNames.Count; i++)
            {
                var newName = $"{teacherLastNames[random.Next(1, teacherLastNames.Count)]} " +
                    $"{teacherFirstNames[random.Next(1, teacherFirstNames.Count)]}";
                Teachers.Add(new Teacher(i + 1, newName));
            }

            for (int i = 0; i < studentLastNames.Count * studentLastNames.Count; i++)
            {
                var newName = $"{studentLastNames[random.Next(1, studentLastNames.Count)]}" + " " +
                    $"{studentMiddleNames[random.Next(1, studentMiddleNames.Count)]}" + " " +
                    $"{studentFirstNames[random.Next(1, studentFirstNames.Count)]}";
                Students.Add(new Student(i + 1, newName));
            }


            for (int i = 0; i < mandatorySubjects.Count; i++)
            {
                Subjects.Add(new Subject(i + 1, mandatorySubjects[i]));
            }

            for (int i = 0; i < classes.Count; i++)
            {
                Classes.Add(new Class(i + 1, classes[random.Next(1, classes.Count)], Teachers[random.Next(1, Teachers.Count)]));
            }

            // dumy 1 sv bắt buộc phai thi 3 mon toan ly anh 
            int examationId = 0;
            for (int i = 0; i < Students.Count(); i++)
            {
                for (int j = 0; j < mandatorySubjects.Count(); j++)
                {
                    var ex = new Examation
                    {
                        Id = examationId++,
                        Subject = Subjects.FirstOrDefault(x => x.Name == mandatorySubjects[j]),
                        Student = Students[i],
                        ExamDate = DateTime.Now,
                        Score = random.Next(1, 10)                        
                    };
                    Examations.Add(ex);                      
                }                
            }          
            
        }

        static void Main(string[] args)
        {
            DummyData();
            #region Test
            //Console.WriteLine("INFORMATION\n--------------------*-------------------- ");
            //Console.WriteLine("TEACHERS\n");
            //foreach (var t in Teachers)
            //{
            //    Console.WriteLine(t.ToString());
            //}

            //Console.WriteLine("--------------------");

            //Console.WriteLine("SUBJECTS\n");

            //foreach (var s in Subjects)
            //{
            //    Console.WriteLine(s.ToString());
            //}

            //Console.WriteLine("--------------------");

            //Console.WriteLine("CLASSES\n");
            //foreach (var c in Classes)
            //{
            //    Console.WriteLine(c.ToString());
            //}

            // Console.WriteLine("--------------------");

            //Console.WriteLine("STUDENTS\n");
            //foreach (var s in Students)
            //{
            //    Console.WriteLine(s.ToString());
            //}
            //Console.WriteLine("--------------------");

            //Console.WriteLine("EXAMATIONS\n");
            //foreach (var s in Examations)
            //{
            //    Console.WriteLine(s.ToString());
            //}
            //Console.WriteLine("--------------------");

            //Console.WriteLine("EXAMATIONS\n");
            //foreach (var s in Students)
            //{
            //    Console.WriteLine(s.Print());
            //}

            //foreach (var s in Examations)
            //{
            //    Console.WriteLine(s.ToString());
            //}
            #endregion
            //foreach (var s in Students)
            //{

            //    Console.WriteLine(s.ToString());
            //}
            foreach (var s in Examations)
            {
                Console.WriteLine(s.ToString());
                Console.WriteLine(s.CheckScore());
                Console.WriteLine(s.CheckAVG());
            }
            foreach (var s in StudentClassificationCriterias)
            {
                Console.WriteLine(s.ClassificationStudent());
            }


            Console.ReadKey();
        }
    }
}
