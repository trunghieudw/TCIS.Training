using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCIS.Training.ClassExample.Entities
{
    public abstract class StudentClassificationCriteria
    {
        public int Id { get; set; }
        public string Classification { get; set; }
        public double AvgScoreFrom { get; set; }
        public double AvgScoreTo { get; set; }
       
        public Examation Examation { get; set; }

        public double AvgScore()
        {
            var ex = new Examation();
                        return;
        }
        public void ClassificationStudent()
        {
            var ex = new Examation();            
        }
    }
}
