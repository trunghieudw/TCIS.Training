using System;

namespace TCIS.Training.ClassExample
{
    public class Teacher : Person
    {
        public Teacher(int id, string name) 
        {
            Id = id;
            Name = name;
        }

        public int TeachId =>  Id; 
        public string TeachName =>  Name; 

        public override string ToString()
        {
            return $"{Id}-{Name}";
        }
    }
}
