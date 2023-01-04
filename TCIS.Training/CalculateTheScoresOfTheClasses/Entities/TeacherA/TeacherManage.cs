using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTheScoresOfTheClasses.Entities.TeacherA
{
    public class TeacherManage : Teacher
    {
        public TeacherManage(int id, string name) : base(id, name)
        {
        }     

        protected double ManagementAllowance { get; set; } //phụ cấp quản lý

     
    }
}
