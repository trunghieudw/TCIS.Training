using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTheScoresOfTheClasses.Entities.Teacher
{
    public class Teacher : Person
    {
        public Teacher(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int TeachId => Id;
        public string TeachName => Name;

        public int Coefficient { get; set; }// hệ số
        public double Allowance { get; set; }// phụ cấp
        public override string ToString()
        {
            return $"{Id}-{Name}-{Coefficient}-{Allowance}";
        }
    }
}
