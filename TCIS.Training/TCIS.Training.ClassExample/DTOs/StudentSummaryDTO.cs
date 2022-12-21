using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TCIS.Training.ClassExample.DTOs
{
    public class StudentSummaryDTO
    {
        public Student Student { get; set; }
        public double AvgScore { get; set;}
        public string Classification { get; set;}

        public override string ToString()
        {
            return $"{Student.StudentId}-{Student.StudentName}-{AvgScore}-{Classification}";
        }
    }
}
