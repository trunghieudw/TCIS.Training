using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCIS.Training.ClassExample.Entities
{
   public class TeacherSalary: SalaryClassification
    {
        public int Id { get; set; }
        public Teacher Teacher { get; set; }
        public int Coefficients { get; set; }

        //public TeacherSalary(int id, Teacher teacher,int coefficients)
        //{
        //    Id = id;
        //    Teacher = teacher;
        //    Coefficients = coefficients;            
        //}

        public override string ToString()
        {
            return $"{Id}-{Teacher.TeachName}-Hệ số lương: {Coefficients}";
        }

    }
}
