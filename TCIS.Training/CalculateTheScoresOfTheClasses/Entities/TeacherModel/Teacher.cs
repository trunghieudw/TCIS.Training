using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTheScoresOfTheClasses.Entities.TeacherModel
{
    public abstract class Teacher : Person
    {
        public Teacher(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int TeachId => Id;
        public string TeachName => Name;

        public int Coefficient { get; set; }// hệ số
        public double BasicSalary { get; set; }// Lương cơ bản

        public int Level { get; set; } // cấp bậc
        public double Allowance { get; set; } //phụ cấp

        public override string ToString()
        {
            return $"{Id}-{Name}";
        }
        public virtual string PrintInfoSalaryTeacher()
        {
            return $"ID: {Id}\t Tên: {Name}\t \nHệ số lương: {Coefficient}\t" +
                $" Lương cơ bản: {BasicSalary}\n" +
                $" Cấp bậc: {Level}\t Phụ cấp: {Allowance}";
        }
        public virtual double CalculateSalary()
        {
            return Coefficient * BasicSalary;
        }

    }
}
