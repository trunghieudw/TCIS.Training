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
        static List<TeacherSummaryDTO> TeacherSummarys { get; set; }
        enum StudentClassification
        {
            TB,
            KHA,
            GIOI
        }
        enum TeacherClassification
        {
            TB,
            KHA,
            GIOI
        }
        static void DummyData()
        {
            const int numberOfStudentInClass = 20;
            const int numberOfClass = 5;
            var mandatorySubjects = new List<string> { "TOAN", "VAN", "ANH" };
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

            //generates data Teacher
            for (int i = 0; i < numberOfClass; i++)
            {
                Teachers.Add(new Teacher(i + 1, $"NGUYEN VAN {i + 1}"));
            }
            // generates data Class Mỗi giáo viên chỉ chủ nhiệm 1 lớp
            for (int i = 0; i < Teachers.Count(); i++)
            {
                Classes.Add(new Class(i + 1, $"12A{i + 1}", Teachers[i]));
            }
            // generates data Mỗi lớp có tối thiểu 20 Sinh Viên
            for (int i = 0; i < Classes.Count(); i++)
            {
                for (int j = 0; j < numberOfStudentInClass; j++)
                {
                    var newName = $"{studentLastNames[random.Next(1, studentLastNames.Count)]}" + " " +
                        $"{middleNames[random.Next(1, middleNames.Count)]}" + " " +
                        $"{studentFirstNames[random.Next(1, studentFirstNames.Count)]}";

                    Students.Add(new Student(int.Parse($"{i + 1}{j + 1}"), newName, Classes[i]));
                }
            }

            // generates data Môn học 
            for (int i = 0; i < mandatorySubjects.Count; i++)
            {
                Subjects.Add(new Subject(i + 1, mandatorySubjects[i]));
            }

            // generates data môn học bắt buộc mỗi sinh viên phải có 3 môn học toán văn anh 
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

            // Xếp loại thành tích học sinh 
            StudentClassificationCriterias.AddRange(new List<StudentClassificationCriteria>
            {
                new StudentClassificationCriteria
                {
                    Id = 1,
                    AvgScoreFrom = 0,
                    AvgScoreTo = 6.4,
                    Classification  = StudentClassification.TB.ToString(),
                },
                new StudentClassificationCriteria
                {
                    Id = 2,
                    AvgScoreFrom = 6.5,
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

            // xếp loại thành tích giáo viên

            TeacherClassificationCriterias.AddRange(new List<TeacherClassificationCriteria>
            {
                new TeacherClassificationCriteria
                {
                    Id = 1,
                    ResultExamationFrom = 0,
                    ResultExamationTo  = 5,
                    Classification  = TeacherClassification.TB.ToString(),
                },
                new TeacherClassificationCriteria
                {
                    Id = 2,
                    ResultExamationFrom = 5,
                    ResultExamationTo = 7.9,
                    Classification  =  TeacherClassification.KHA.ToString(),
                },
                new TeacherClassificationCriteria
                {
                    Id = 3,
                    ResultExamationFrom = 8,
                    ResultExamationTo = 10,
                    Classification  =  TeacherClassification.GIOI.ToString(),
                }
            });

        }

        static void Main(string[] args)
        {
            DummyData();

            Console.WriteLine("============");

            //Console.WriteLine("Teachers = ", Teachers.Count);
            //foreach (var t in Teachers)
            //{
            //    Console.WriteLine(t.ToString());
            //}


            //Console.WriteLine("============");
            //Console.WriteLine("Classes = ", Classes.Count);
            //foreach (var c in Classes)
            //{
            //    Console.WriteLine(c.ToString());
            //}


            //Console.WriteLine("============");
            //Console.WriteLine("Students = ", Students.Count);
            //foreach (var s in Students)
            //{
            //    Console.WriteLine(s.ToString());
            //}

            foreach (var student in Students)
            {
                var studentExamations = Examations.Where(x => x.Student.StudentId == student.StudentId);
                if (studentExamations == null)
                    continue;

                var avgScore = Math.Round(studentExamations.Sum(x => x.Score) / 3, 2);

                var classification = StudentClassificationCriterias
                    .FirstOrDefault(x => x.AvgScoreFrom <= avgScore && avgScore <= x.AvgScoreTo)
                    .Classification;

                StudentSummarys.Add(new StudentSummaryDTO
                {
                    Student = student,
                    AvgScore = avgScore,
                    Classification = classification
                });

            }

            //foreach (var summary in StudentSummarys)
            //{
            //    Console.WriteLine(summary.ToString());
            //}
               
            //Console.WriteLine("============");

            foreach (var @class in Classes)
            {
                Console.WriteLine("============");
                Console.WriteLine($"LOP {@class.Name}");

                var summaryByClass = StudentSummarys.Where(x => x.Student.Class.Id == @class.Id);
             
                var totalStudentTB = summaryByClass.Count(x => x.Classification == StudentClassification.TB.ToString());
                var totalStudentKHA = summaryByClass.Count(x => x.Classification == StudentClassification.KHA.ToString());
                var totalStudentGIOI = summaryByClass.Count(x => x.Classification == StudentClassification.GIOI.ToString());
                //==> Rate

                var totalStudentTBPercent = Math.Round((20.0 / totalStudentTB) * 100, 2);
                var totalStudentKHAPercent = Math.Round((20.0 / totalStudentKHA) * 100, 2);
                var totalStudentGIOIPercent = Math.Round((20.0 / totalStudentGIOI) * 100, 2);


                //foreach (var s in summaryByClass)
                //{
                //    Console.WriteLine(s.ToString());
                //}

                Console.WriteLine("============");
            }

            Console.ReadKey();
        }
    }
}


/*
 * 
 * 
 * 
 * XL Giáo Viên	TB F	TB T	KHA F	KHA T	GIOI F	GIOI T
    TB	        50	    100	    0	    100	    0	    100
    KHA	        0	    10	    55	    100	    10	    100
    GIỎI	        0	    0	    70	    100	    30	    100
 * 
 * 
 */