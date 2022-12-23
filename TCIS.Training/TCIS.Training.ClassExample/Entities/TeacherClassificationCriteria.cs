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
        public double ResultExamationMediumFrom { get; set; }
        public double ResultExamationMediumTo { get; set; }
        public double ResultExamationRatherFrom { get; set; }
        public double ResultExamationRatherTo { get; set; }
        public double ResultExamationGoodFrom { get; set; }
        public double ResultExamationGoodTo { get; set; }
        
    }
}
