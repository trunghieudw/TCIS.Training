using System;

namespace TCIS.Training.ClassExample
{
    public class Student : Person
    {
        public string Code { get; set; } = Guid.NewGuid().ToString();
        public Class Class { get; set; }

        public int StudentId => Id;
        public string StudentName => Name;

        public Student(int id, string name, Class @class)
        {
            Id = id;
            Name = name;
            Class = @class;
        }

        public override string ToString()
        {
            return $"{Id}-{Name}";
        }

    }
}
