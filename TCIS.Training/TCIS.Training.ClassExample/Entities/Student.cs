using System;

namespace TCIS.Training.ClassExample
{
    public class Student : Person
    {
        public string Code { get; set; } = Guid.NewGuid().ToString();
        public Class Class { get; set; }
        public override string ToString()
        {
            return $"{Id}-{Name}";
        }
    }
}
