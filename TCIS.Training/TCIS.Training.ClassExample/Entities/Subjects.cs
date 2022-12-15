using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCIS.Training.ClassExample
{
    public class Subjects: ISubjects
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public double Scores { get; set; }
    }


}
