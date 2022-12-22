using System;
using System.Collections.Generic;
using System.Linq;
using TCIS.Training.ClassExample.DTOs;
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
        static List<TeacherClassificationCriteria> TeacherClassificationCriterias { get; set; }
        static List<TeacherSalary> TeacherSalarys { get; set; }
        static List<SalaryClassification> SalaryClassifications { get; set; }
        static List<StudentSummaryDTO> StudentSummarys { get; set; }
        static List<TeacherSummaryDTO>TeacherSummarys { get; set; }
        enum StudentClassification
        {
            TB,
            KHA,
            GIOI
        } enum TeacherClassification
        {
            TB,
            KHA,
            GIOI
        }
        static void DummyData()
        {
            const int studentInClass = 20;
            var mandatorySubjects = new List<string> { "TOAN", "VAN", "ANH" };
            var classes = new List<string> { "12A1", "12A2", "12A3", "12A4", "12A5", "12A6", "12A7" };
            var teacherLastNames = new List<string> { "NGUYEN", "TRAN", "LE", "HOANG", "LY" };
            var teacherFirstNames = new List<string> { "DUNG", "HIEU", "TIEN", "NHAN", "QUAN" };
            var studentLastNames = new List<string> { "NGUYEN", "TRAN", "LE", "HOANG", "LY", "DINH" };
            var studentFirstNames = new List<string> { "HIEU", "SON", "NAM", "DUNG", "TIEN", "QUI", "KHAI", "PHI" };
            var middleNames = new List<string> { "VAN", "THANH", "TRUNG", "HOAI", "HOANG" };
            var classification = new List<string> { "GIOI", "KHA", "TRUNG BINH" };
         

            Teachers = new List<Teacher>();
            Classes = new List<Class>();
            Subjects = new List<Subject>();
            Students = new List<Student>();
            Examations = new List<Examation>();
            StudentClassificationCriterias = new List<StudentClassificationCriteria>();
            TeacherClassificationCriterias = new List<TeacherClassificationCriteria>();
            TeacherSalarys = new List<TeacherSalary>();
            SalaryClassifications = new List<SalaryClassification>();
            StudentSummarys = new List<StudentSummaryDTO>();
            TeacherSummarys = new List<TeacherSummaryDTO>();


            var random = new Random();
            int classCount = classes.Count();

            #region test

            //for (int i = 0; i < classCount * studentInClass; i++)
            //{
            //    //Students.Add(new Student(i + 1, newName));
            //}
            //for (int i = 0; i < classes.Count; i++)
            //{
            //    Classes.Add(new Class(i + 1, classes[random.Next(1, classes.Count)], Teachers[random.Next(1, Teachers.Count)]));
            //}
            #endregion

            for (int i = 0; i < classCount; i++)
            {                
                var newName = $"{teacherLastNames[random.Next(1, teacherLastNames.Count)]}" + " " +
                     $"{middleNames[random.Next(1, middleNames.Count)]}" + " " +
                     $"{teacherFirstNames[random.Next(1, teacherFirstNames.Count)]}";
                
                Classes.Add(new Class(i+1,classes[random.Next(1,classCount)], Teachers.FirstOrDefault(x=>x.TeachName == newName)));
            }
                  
            for (int i = 0; i < classCount * studentInClass; i++)
            {
                var newName = $"{studentLastNames[random.Next(1, studentLastNames.Count)]}" + " " +
                    $"{middleNames[random.Next(1, middleNames.Count)]}" + " " +
                    $"{studentFirstNames[random.Next(1, studentFirstNames.Count)]}";

                var newClass = $"{Classes[random.Next(1, classes.Count())]}";
                //Students.Add(new Student(i + 1, newName, Students.FirstOrDefault(x => x.Class.Id == )));
            }

            for (int i = 0; i < mandatorySubjects.Count; i++)
            {
                Subjects.Add(new Subject(i + 1, mandatorySubjects[i]));
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

            StudentClassificationCriterias.AddRange(new List<StudentClassificationCriteria>
            {
                new StudentClassificationCriteria
                {
                    Id = 1,
                    AvgScoreFrom = 0,
                    AvgScoreTo = 6.9,
                    Classification  = StudentClassification.TB.ToString(),
                },
                new StudentClassificationCriteria
                {
                    Id = 2,
                    AvgScoreFrom = 7,
                    AvgScoreTo = 7.9,
                    Classification  =  StudentClassification.KHA.ToString(),
                },
                new StudentClassificationCriteria
                {
                    Id = 3,
                    AvgScoreFrom = 8,
                    AvgScoreTo = 10,
                    Classification  =  StudentClassification.GIOI.ToString(),
                }
            }); 
           
        }

        static void Main(string[] args)
        {
            DummyData();

            Console.WriteLine(Students.Count());
            Console.WriteLine("============");

            foreach (var student in Students)
            {
                var studentExamations = Examations.Where(x => x.Student.StudentId == student.StudentId);
                if (studentExamations == null)
                    continue;

                var avgScore = Math.Round(studentExamations.Sum(x => x.Score) / 3,2);


                var classification = StudentClassificationCriterias
                    .FirstOrDefault(x => x.AvgScoreFrom <= avgScore && avgScore <= x.AvgScoreTo)
                    .Classification;

                StudentSummarys.Add(new StudentSummaryDTO
                {
                    Student  = student,
                    AvgScore = avgScore,
                    Classification = classification
                });
            }
            foreach (var summary in StudentSummarys)
            {
                Console.WriteLine(summary.ToString());
            }

            Console.WriteLine("============");
            foreach (var es in Classes)
            {
                Console.WriteLine(es.ToString());
            }

            Console.ReadKey();
        }
    }
}
