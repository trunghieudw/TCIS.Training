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
        public int Level { get; set; }
        
    }
}
