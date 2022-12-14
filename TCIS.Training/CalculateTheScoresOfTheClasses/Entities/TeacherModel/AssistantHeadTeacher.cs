using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTheScoresOfTheClasses.Entities.TeacherModel
{
    public class AssistantHeadTeacher: TeacherManage
    {
        public AssistantHeadTeacher(int id, string name) : base(id, name)
        {
        }
        /// <summary>
        /// ctor 
        /// </summary>
        /// <param mã id ="id"></param>
        /// <param tên="name"></param>
        /// <param hệ số lương="coefficient"></param>
        /// <param lương cơ bản="basicSalary"></param>
        /// <param cấp bậc="level"></param>
        /// <param phụ cấp="allowance"></param>
        /// <param phụ cấp quản lý="managementAllowance"></param>
        public AssistantHeadTeacher(int id, string name, int coefficient, double basicSalary, int level, double allowance, double managementAllowance) : base(id, name)
        {
            Coefficient = coefficient;
            BasicSalary = basicSalary;
            Level = level;
            Allowance = allowance;
            ManagementAllowance = managementAllowance;
        }
        public override string ToString()
        {
            return base.ToString();
        }
        /// <summary>
        /// Coefficient: hệ số lương
        /// BasicSalary: lương cơ bản
        /// Level: cấp bậc
        /// Allowance: phụ cấp
        /// ManagementAllowance: phụ cấp quản lý
        /// </summary>
        /// <returns>
        /// In thông tin
        /// </returns>
        public override string PrintInfoSalaryTeacher()
        {
            return base.PrintInfoSalaryTeacher();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override double CalculateSalary()
        {
            return base.CalculateSalary();
        }
    }
}
