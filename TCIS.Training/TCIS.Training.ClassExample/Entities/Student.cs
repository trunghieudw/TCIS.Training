using System;

namespace TCIS.Training.ClassExample
{
    public class Student : Person
    {
        public string Code { get; set; } = Guid.NewGuid().ToString();
        public Class Class { get; set; }
        public Subject Subject { get; set; }
        public int StudentId => Id;
        public string StudentName => Name;
        //public string StudentSubject => Subject.Name;

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public Student(int id, string name, string subject)
        {
            Id = id;
            Name = name;
            Subject.Name= subject;
        }
        public override string ToString()
        {
            return $"{Id}-{Name}";
        }
        public string Print()
        {
            return $"{Id}-{Name}-{Subject.Name}";
        }


    }
}
