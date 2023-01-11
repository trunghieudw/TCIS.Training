using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTheScoresOfTheClasses.Entities.TeacherModel
{
    public class TeacherManage : Teacher
    {
        public TeacherManage(int id, string name) : base(id, name)
        {
        }

        protected double ManagementAllowance { get; set; } //phụ cấp quản lý

        //public override string ToString()
        //{
        //    return $"{Id}-{Name}";
        //}
        public override string PrintInfoSalaryTeacher()
        {
            return base.PrintInfoSalaryTeacher()+ $"PCQL:{ManagementAllowance}";
        }        
        public override double CalculateSalary()
        {
            return base.CalculateSalary()+ Allowance + ManagementAllowance ;
        }
    }
}
