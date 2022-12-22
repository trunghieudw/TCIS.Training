using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCIS.Training.ClassExample.DTOs
{
    public class TeacherSummaryDTO
    {
        public Teacher Teacher { get; set; } 
        public string Classification { get; set; }

        public override string ToString()
        {
            return $"{Teacher.TeachId}-{Teacher.TeachName}-{Classification}";
        }
    }
}
