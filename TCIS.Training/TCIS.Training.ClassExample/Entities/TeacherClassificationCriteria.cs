using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCIS.Training.ClassExample
{
    public class TeacherClassificationCriteria
    {
        public int Id { get; set; }
        public string Classification { get; set; }
        public double ResultExamationMedium { get; set; }
        public double ResultExamationRather { get; set; }
        public double ResultExamationGood { get; set; }
        
    }
}
