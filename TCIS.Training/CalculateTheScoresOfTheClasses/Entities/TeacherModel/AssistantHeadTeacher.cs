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
        public override double CalculateSalary()
        {
            return Coefficient * BasicSalary + Allowance + ManagementAllowance;
        }

    }
}
