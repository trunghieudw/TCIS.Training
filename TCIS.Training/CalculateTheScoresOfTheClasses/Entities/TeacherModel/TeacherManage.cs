using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTheScoresOfTheClasses.Entities.TeacherModel
{
    public class TeacherManage : Teacher
    {
        public TeacherManage(int id, string name): base(id, name)
        {
        }     

        protected double ManagementAllowance { get; set; } //phụ cấp quản lý

        public override string ToString()
        {
            return $"{Id}-{Name}";
        }
        public override string PrintInfoSalaryTeacher()
        {
            return $"ID: {Id}\t Tên: {Name}\t \nHệ số lương: {Coefficient}\t Lương cơ bản: {BasicSalary}\n Cấp bậc: {Level}\t Phụ cấp: {Allowance}";
        }        
        public override double CalculateSalary()
        {
            return Coefficient * BasicSalary+ Allowance + ManagementAllowance ;
        }
    }
}
