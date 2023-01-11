using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTheScoresOfTheClasses.Entities.TeacherModel
{
    public class HomeroomTeacher :Teacher
    {
        public HomeroomTeacher(int id, string name) : base(id, name)
        {
        }
        public HomeroomTeacher(int id, string name, int coefficient, double basicSalary, int level , double allowance): base(id, name)
        {
            Coefficient = coefficient;
            BasicSalary= basicSalary;
            Level= level;
            Allowance = allowance;
        }
        public int HomeroomTeacherId => Id;
        public string HomeroomTeacherName => Name;
 
        public override string ToString()
        {
            return $"{Id}-{Name}";
        }
        public override string PrintInfoSalaryTeacher()
        {
            return $"ID: {Id}\t Tên: {Name}\t " +
                $"\nHệ số lương: {Coefficient}\t Lương cơ bản: {BasicSalary}\t" +
                $" \nCấp bậc: {Level}\t Phụ cấp: {Allowance}";
        }
        public override double CalculateSalary()
        {
            return  Coefficient* BasicSalary + Allowance;
        }

    }
}
