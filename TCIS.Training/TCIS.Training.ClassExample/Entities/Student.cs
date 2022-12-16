using System;

namespace TCIS.Training.ClassExample
{
    public class Student : Person
    {
        public string Code { get; set; } = Guid.NewGuid().ToString();
        public Class Class { get; set; }
        public override string ToString()
        {
            return $"{Code}-{Name}";
        }
        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public int StudentId => Id;
        public string StudentName => Name;

    }
}
